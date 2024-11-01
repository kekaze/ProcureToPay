using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

namespace ProcureToPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoriesController : ControllerBase
    {
        private readonly ProcureToPayContext _dbContext;
        public InventoriesController(ProcureToPayContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetInventories()
        {
            IQueryable<Inventory> inventories = _dbContext.Inventories;

            return Ok(await inventories.ToArrayAsync());
        }
    }
}
