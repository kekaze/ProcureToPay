using Microsoft.EntityFrameworkCore;

namespace ProcureToPay.Models
{
    public class ProcureToPayContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProcureToPayContext(DbContextOptions<ProcureToPayContext> options) : base(options) { }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<PurchaseRequestMaterial> PurchaseRequestMaterials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseRequest>()
                .HasMany(pr => pr.Materials)
                .WithMany(m => m.PurchaseRequests)
                .UsingEntity<PurchaseRequestMaterial>(
                    j => j
                        .HasOne(pm => pm.Material)
                        .WithMany(m => m.PurchaseRequestMaterials)
                        .HasForeignKey(pm => pm.MaterialId),
                    j => j
                        .HasOne(pm => pm.PurchaseRequest)
                        .WithMany(pr => pr.PurchaseRequestMaterials)
                        .HasForeignKey(pm => pm.PurchaseRequestId),
                    j => j.ToTable("PurchaseRequestMaterials").HasData(
                        new { PurchaseRequestId = 1, MaterialId = 1, Quantity = 1F },
                        new { PurchaseRequestId = 1, MaterialId = 2, Quantity = 2F },
                        new { PurchaseRequestId = 2, MaterialId = 1, Quantity = 1F },
                        new { PurchaseRequestId = 3, MaterialId = 1, Quantity = 1F },
                        new { PurchaseRequestId = 3, MaterialId = 2, Quantity = 4F },
                        new { PurchaseRequestId = 3, MaterialId = 3, Quantity = 3F },
                        new { PurchaseRequestId = 4, MaterialId = 5, Quantity = 2F },
                        new { PurchaseRequestId = 5, MaterialId = 4, Quantity = 1F },
                        new { PurchaseRequestId = 6, MaterialId = 3, Quantity = 1F },
                        new { PurchaseRequestId = 6, MaterialId = 2, Quantity = 18F }
                    )
                );

            modelBuilder.Entity<Material>()
                .HasIndex(m => m.MaterialCode)
                .IsUnique();

            modelBuilder.Entity<Company>()
                .HasIndex(c => c.CompanyId)
                .IsUnique();

            modelBuilder.Entity<PurchaseRequest>()
                .HasIndex(pr => pr.PurchaseId)
                .IsUnique();

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Company)
                .WithMany(c => c.Inventories)
                .HasForeignKey(i => i.CompanyId);

            modelBuilder.Entity<Inventory>()
                .Property(i => i.LatestPrice)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Inventory>()
                .Property(i => i.Quantity)
                .HasPrecision(18, 2);

            // Optional: configure defaults for DateTime columns, indexes, etc.
            modelBuilder.Entity<Material>().Property(m => m.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Material>().Property(m => m.UpdatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Inventory>().Property(i => i.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<Inventory>().Property(i => i.UpdatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<PurchaseRequest>().Property(pr => pr.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            modelBuilder.Entity<PurchaseRequest>().Property(pr => pr.UpdatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
