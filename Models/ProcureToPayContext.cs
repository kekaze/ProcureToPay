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
            modelBuilder.Entity<Material>()
                .HasMany(pr => pr.PurchaseRequests)
                .WithMany(m => m.Materials)
                .UsingEntity<PurchaseRequestMaterial>(
                    j => j
                        .HasOne(pm => pm.PurchaseRequest)
                        .WithMany(pr => pr.PurchaseRequestMaterials)
                        .HasForeignKey(pm => pm.PurchaseRequestId),
                    j => j
                        .HasOne(pm => pm.Material)
                        .WithMany(m => m.PurchaseRequestMaterials)
                        .HasForeignKey(pm => pm.MaterialId),
                    j => j.ToTable("PurchaseRequestMaterials").HasData(
                        new { PurchaseRequestId = 435000001, MaterialId = 100001, Quantity = 1F },
                        new { PurchaseRequestId = 435000001, MaterialId = 100002, Quantity = 2F },
                        new { PurchaseRequestId = 435000002, MaterialId = 100001, Quantity = 1F },
                        new { PurchaseRequestId = 435000003, MaterialId = 100001, Quantity = 1F },
                        new { PurchaseRequestId = 435000003, MaterialId = 100002, Quantity = 4F },
                        new { PurchaseRequestId = 435000003, MaterialId = 200001, Quantity = 3F },
                        new { PurchaseRequestId = 435000004, MaterialId = 200002, Quantity = 2F },
                        new { PurchaseRequestId = 435000005, MaterialId = 100003, Quantity = 1F },
                        new { PurchaseRequestId = 435000006, MaterialId = 200001, Quantity = 1F },
                        new { PurchaseRequestId = 435000006, MaterialId = 100002, Quantity = 18F }
                    )
                );

            modelBuilder.Entity<Material>()
                .HasKey(m => m.MaterialCode);

            modelBuilder.Entity<Material>()
                .Property(m => m.MaterialCode)
                .ValueGeneratedNever();

            modelBuilder.Entity<Company>()
                .HasIndex(c => c.CompanyId)
                .IsUnique();

            modelBuilder.Entity<PurchaseRequest>()
                .HasKey(pr => pr.PurchaseId);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Company)
                .WithMany(c => c.Inventories)
                .HasForeignKey(i => i.CompanyId);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Material)
                .WithMany(c => c.Inventories)
                .HasForeignKey(i => i.MaterialId);

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
