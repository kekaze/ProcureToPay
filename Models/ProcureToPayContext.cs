using Microsoft.EntityFrameworkCore;

namespace ProcureToPay.Models
{
    public class ProcureToPayContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProcureToPayContext(DbContextOptions<ProcureToPayContext> options) : base(options) { }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<PurchaseRequest> PurchaseRequests { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseRequest>()
                .HasMany(pr => pr.Materials)
                .WithMany(m => m.PurchaseRequests)
                .UsingEntity(j => j.ToTable("PurchaseRequestMaterials"));

            modelBuilder.Entity<PurchaseRequest>()
                .HasIndex(m => m.PurchaseId)
                .IsUnique();

            modelBuilder.Entity<Material>()
                .HasIndex(m => m.MaterialCode)
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
        }
    }
}
