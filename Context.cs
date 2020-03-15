using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace efcore.dotnetcoders.demo
{
    public class Context : DbContext
    {
        public DbSet<StockRecord> StockRecords { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new StockRecordMapping());
            base.OnModelCreating(builder);
        }
    }
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            return new Context(new DbContextOptionsBuilder().UseSqlServer(DatabaseData.ConnectionString).Options);
        }
    }
}
