using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProcureToPay.Models;

namespace ProcureToPay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ProcureToPayContext _dbContext;
        public CompanyController(ProcureToPayContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult> GetCompanies()
        {
            IQueryable<Company> companies = _dbContext.Companies;
            return Ok(await companies.ToArrayAsync());
        }

    }
}
