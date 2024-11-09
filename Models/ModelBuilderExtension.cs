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

            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { Id = 1, CompanyId = 1, MaterialId = 1, Quantity = 3, LatestPrice = 350000.00m },
                new Inventory { Id = 2, CompanyId = 1, MaterialId = 2, Quantity = 5, LatestPrice = 90000.00m },
                new Inventory { Id = 3, CompanyId = 1, MaterialId = 3, Quantity = 10, LatestPrice = 20000.00m },
                new Inventory { Id = 4, CompanyId = 2, MaterialId = 3, Quantity = 6, LatestPrice = 20000.00m },
                new Inventory { Id = 5, CompanyId = 2, MaterialId = 5, Quantity = 1, LatestPrice = 32000.00m },
                new Inventory { Id = 6, CompanyId = 2, MaterialId = 4, Quantity = 3, LatestPrice = 1300400.00m },
                new Inventory { Id = 7, CompanyId = 3, MaterialId = 1, Quantity = 4, LatestPrice = 350000.00m },
                new Inventory { Id = 8, CompanyId = 3, MaterialId = 3, Quantity = 7, LatestPrice = 20000.00m },
                new Inventory { Id = 9, CompanyId = 3, MaterialId = 4, Quantity = 2, LatestPrice = 1300400.00m },
                new Inventory { Id = 10, CompanyId = 3, MaterialId = 5, Quantity = 0, LatestPrice = 32000.00m }
            );

            modelBuilder.Entity<PurchaseRequest>().HasData(
                new PurchaseRequest { Id = 1, PurchaseId = 435000001, CompanyId = 1, Purpose = "For repair and maintenance of Engine 1", Type = "Normal", Status = "For approval" },
                new PurchaseRequest { Id = 2, PurchaseId = 435000002, CompanyId = 2, Purpose = "For repair and maintenance of Engine 2", Type = "Urgent", Status = "For approval" },
                new PurchaseRequest { Id = 3, PurchaseId = 435000003, CompanyId = 3, Purpose = "For repair and maintenance of Engine 3", Type = "Urgent", Status = "For approval" },
                new PurchaseRequest { Id = 4, PurchaseId = 435000004, CompanyId = 1, Purpose = "For 4000RH PMS of Air Compressor X", Type = "Normal", Status = "For approval" },
                new PurchaseRequest { Id = 5, PurchaseId = 435000005, CompanyId = 1, Purpose = "For annual maintenance of T/C for Engine 10", Type = "Normal", Status = "For approval" },
                new PurchaseRequest { Id = 6, PurchaseId = 435000006, CompanyId = 2, Purpose = "For 62000RH PMS of Engine 7", Type = "Normal", Status = "For approval" }
            );
        }
    }
}