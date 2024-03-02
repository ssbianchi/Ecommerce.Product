using Ecommerce.Product.Application.Shared.Dto;
using Ecommerce.Product.Domain.Entity.Readonly.Dapper;

namespace Ecommerce.Product.Application.Shared.Profile
{
    public class SharedProfile : AutoMapper.Profile
    {
        public SharedProfile()
        {
            CreateMap<DapperIdName, IdNameDto>();
        }
    }
}
