using Ecommerce.Product.Application.Product.Dto;

namespace Ecommerce.Product.Application.Product.Profile
{
    public class ProductProfile : AutoMapper.Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Ecommerce.Product.Domain.Entity.Product.Product>().ReverseMap();
        }
    }
}
