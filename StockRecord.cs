using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efcore.dotnetcoders.demo
{
    public class StockRecord
    {
        public long Id { get; protected set; }
        public string Product { get; set; }
        public string Address { get; set; }
        public decimal Quantity { get; set; }

        protected StockRecord() { }

        public StockRecord(string product, string address, decimal quantity)
        {
            Product = product;
            Address = address;
            Quantity = quantity;
        }
    }

    public class StockRecordMapping : IEntityTypeConfiguration<StockRecord>
    {
        public void Configure(EntityTypeBuilder<StockRecord> builder)
        {
            builder.ToTable("StockRecord");
            builder.Property(d => d.Product).IsUnicode(false).HasMaxLength(15);
            builder.Property(d => d.Address).IsUnicode(false).HasMaxLength(15);
        }
    }

    public class ProductStockDto
    {
        public string Product { get; set; }
        public string Address { get; set; }
        public decimal Quantity { get; set; }
    }
}
