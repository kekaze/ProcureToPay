using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

namespace ProcureToPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialsController : ControllerBase
    {
        private readonly ProcureToPayContext _dbContext;
        public MaterialsController(ProcureToPayContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<ActionResult> GetMaterials()
        {
            IQueryable<Material> materials = _dbContext.Materials;

            return Ok(await materials.ToArrayAsync());
        }

        [HttpGet("{materialCode}")]
        public async Task<ActionResult> GetMaterials(int matcode)
        {
            var material = await _dbContext.Materials.FindAsync(matcode);
            
            if (material == null)
            {
                return NotFound();
            }
            return Ok(material);
        }
    }
}
