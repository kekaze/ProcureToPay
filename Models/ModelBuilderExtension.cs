using Microsoft.EntityFrameworkCore;

namespace ProcureToPay.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, CompanyId = "CMP100", CompanyName = "Company 1", Status = "Active" },
                new Company { Id = 2, CompanyId = "CMP101", CompanyName = "Company 2", Status = "Active" },
                new Company { Id = 3, CompanyId = "CMP102", CompanyName = "Company 3", Status = "Active" });
        }
    }
}