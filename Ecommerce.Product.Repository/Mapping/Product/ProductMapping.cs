using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Product.Repository.Mapping.Product
{
    public class ProductMapping : IEntityTypeConfiguration<Ecommerce.Product.Domain.Entity.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Ecommerce.Product.Domain.Entity.Product.Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("Id");
            builder.Property(x => x.Name).IsRequired().HasColumnName("Name");
            builder.Property(x => x.Desc).IsRequired().HasColumnName("Desc");
            builder.Property(x => x.ProductTypeId).IsRequired().HasColumnName("ProductTypeId");
            builder.Property(x => x.ProductInventoryId).IsRequired().HasColumnName("ProductInventoryId");
            builder.Property(x => x.Price).IsRequired().HasColumnName("Price");
        }
    }
}
