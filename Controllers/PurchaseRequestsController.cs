using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

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
        public async Task<ActionResult> GetPurchaseRequest(int purchaseRequestId)
        {
            IQueryable<PurchaseRequest> purchaseRequest = _dbContext.PurchaseRequests
                .Include(pr => pr.Materials);

            if (purchaseRequest == null)
            {
                return NotFound();
            }

            purchaseRequest = purchaseRequest.Where(
                pr => pr.PurchaseId == purchaseRequestId);

            return Ok(await purchaseRequest.ToArrayAsync());
        }
    }
}
