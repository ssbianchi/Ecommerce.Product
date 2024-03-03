using Ecommerce.Product.Application.Product.Dto;
using Ecommerce.Product.Domain.Entity.Readonly.Dapper.Product;

namespace Ecommerce.Product.Application.Product.Profile
{
    public class ProductProfile : AutoMapper.Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto, Ecommerce.Product.Domain.Entity.Product.Product>().ReverseMap();
            CreateMap<ProductAllInfoDto, DapperProductAllInfo>().ReverseMap();
        }
    }
}
