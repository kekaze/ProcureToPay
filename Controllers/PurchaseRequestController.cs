using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

namespace ProcureToPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseRequestController : ControllerBase
    {
        private readonly ProcureToPayContext _dbContext;

        public PurchaseRequestController(ProcureToPayContext dbContext)
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
            var purchaseRequest = await _dbContext.PurchaseRequests.FindAsync(purchaseRequestId);
            if (purchaseRequest == null)
            {
                return NotFound();
            }
            return Ok(purchaseRequest);
        }
    }
}
