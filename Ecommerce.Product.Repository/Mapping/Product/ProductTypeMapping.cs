using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Product.Repository.Mapping.Product
{
    public class ProductTypeMapping : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.ToTable("ProductTypes");
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("Id");
            builder.Property(x => x.Name).IsRequired().HasColumnName("Name");
            builder.Property(x => x.Desc).IsRequired().HasColumnName("Desc");
        }
    }
}
