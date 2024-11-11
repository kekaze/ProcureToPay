using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;
using static ProcureToPay.DTOs.ModelDtos;

namespace ProcureToPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseRequestsController : ControllerBase
    {
        private readonly ProcureToPayContext _dbContext;

        public PurchaseRequestsController(ProcureToPayContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetPurchaseRequests()
        {
            IQueryable<PurchaseRequest> purchaseRequests = _dbContext.PurchaseRequests;

            return Ok(await purchaseRequests.ToArrayAsync());
        }

        [HttpGet("{purchaseRequestId}")]
        public async Task<ActionResult<SinglePurchaseRequestDto>> GetPurchaseRequest(int purchaseRequestId)
        {
            var purchaseRequest = await _dbContext.PurchaseRequests
                .Where(pr => pr.PurchaseId == purchaseRequestId)
                .Select(pr => new SinglePurchaseRequestDto
                {
                    PurchaseId = pr.PurchaseId,
                    Purpose = pr.Purpose,
                    Type = pr.Type,
                    Status = pr.Status,
                    CreatedAt = pr.CreatedAt,
                    CompanyId = pr.Company.CompanyId,
                    CompanyName = pr.Company.CompanyName,
                    Materials = pr.PurchaseRequestMaterials
                        .Select(pm => new MaterialsDto
                        {
                            MaterialCode = pm.Material.MaterialCode,
                            MaterialName = pm.Material.MaterialName,
                            Quantity = pm.Quantity
                        }).ToList()
                }).FirstOrDefaultAsync();

            if (purchaseRequest == null)
            {
                return NotFound();
            }

            return Ok(purchaseRequest);
        }

        [HttpGet("{purchaseRequestId}/material/{materialCode}")]
        public async Task<ActionResult<PurchaseRequestMaterial>> GetPrMaterials(int purchaseRequestId, int materialCode)
        {
            IQueryable<PurchaseRequestMaterial> purchaseRequestMaterials = _dbContext.PurchaseRequestMaterials.Where(
                pr => pr.MaterialId == materialCode && pr.PurchaseRequestId == purchaseRequestId);

            return Ok(await purchaseRequestMaterials.ToArrayAsync());
        }
    }
}
