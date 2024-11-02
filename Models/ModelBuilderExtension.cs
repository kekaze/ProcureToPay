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

            modelBuilder.Entity<Material>().HasData(
                    new Material { Id = 1, MaterialCode = 100001, MaterialName = "Cylinder Head 244 001", Category = "Spare Parts", Brand = "Brand X", Dimensions = "Dimension XXX" },
                    new Material { Id = 2, MaterialCode = 100002, MaterialName = "Fuel Injector 125 987", Category = "Spare Parts", Brand = "Brand Y", Dimensions = "Dimension YYY" },
                    new Material { Id = 3, MaterialCode = 200001, MaterialName = "Q8 Mahler G5 SAE 40", Category = "Chemicals", Brand = "Q8", Dimensions = "208 Liters" },
                    new Material { Id = 4, MaterialCode = 100003, MaterialName = "Turbocharger 876 543", Category = "Spare Parts", Brand = "Brand A", Dimensions = "Dimension AAA" },
                    new Material { Id = 5, MaterialCode = 200002, MaterialName = "Shell Corena S4 R", Category = "Chemicals", Brand = "Shell", Dimensions = "20 Liters" }
            );
        }
    }
}