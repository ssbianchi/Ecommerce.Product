using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Product.Repository.Mapping.Product
{
    public class ProductInventoryMapping : IEntityTypeConfiguration<ProductInventory>
    {
        public void Configure(EntityTypeBuilder<ProductInventory> builder)
        {
            builder.ToTable("ProductInventories");
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("Id");
            builder.Property(x => x.Qtd).IsRequired().HasColumnName("Qtd");
        }
    }
}
