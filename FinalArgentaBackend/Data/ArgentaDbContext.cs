using FinalArgentaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalArgentaBackend.Data
{
    public class ArgentaDbContext : DbContext
    {
        public ArgentaDbContext(DbContextOptions<ArgentaDbContext> opts)
            : base(opts)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var prop in builder.Model
                                        .GetEntityTypes()
                                        .SelectMany(t => t.GetProperties())
                                        .Where(p => p.ClrType == typeof(decimal)))
            {
                prop.SetColumnType("decimal(18, 6)");
            }

            builder.Entity<InvestmentEntry>()
                   .Property(ie => ie.TotalPrice)
                   .HasComputedColumnSql("\"Count\" * \"UnitPrice\"", stored: true);

            foreach (var entity in builder.Model
                                          .GetEntityTypes()
                                          .Where(t => t.ClrType.IsSubclassOf(typeof(RelatedEntity<>))))
            {
                builder.Entity(entity.Name, e =>
                {
                    e.Property("Id")
                     .HasDefaultValue(Guid.NewGuid());
                    e.Property("ForeignId")
                     .HasDefaultValue(Guid.NewGuid());
                    e.Property("CreatedAt")
                     .HasDefaultValueSql("CURRENT_TIMEZONE()");
                    e.Property("UpdatedAt")
                     .HasDefaultValueSql("CURRENT_TIMEZONE()");
                });
            }
        }

        public DbSet<Users> Users { get; set; } = null!;

        public DbSet<Budget> Budget { get; set; } = null!;

        public DbSet<Transaction> Transaction { get; set; } = null!;

        public DbSet<Goal> Goal { get; set; } = null!;

        public DbSet<Investment> Investment { get; set; } = null!;

        public DbSet<BudgetItem> BudgetItem { get; set; } = null!;

        public DbSet<GoalUpdate> GoalUpdate { get; set; } = null!;

        public DbSet<InvestmentEntry> InvestmentEntry { get; set; } = null!;
    }
}
