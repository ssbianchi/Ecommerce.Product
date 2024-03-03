using Ecommerce.Product.Domain.Entity.Readonly.Dapper.Product;
using Ecommerce.Product.Domain.Entity.Readonly.Repository;
using Ecommerce.Product.Repository.Context;
using Ecommerce.Product.Repository.Repository.Options;
using Microsoft.Extensions.Options;

namespace Ecommerce.Product.Repository.Repository
{
    public class ReadonlyRepository : UnitOfWorkQuery, IReadonlyRepository
    {
        public ReadonlyRepository(IOptions<ConnectionStringOptions> options) : base(options.Value.ConnectionString)
        {

        }

        #region User
        public async Task<IEnumerable<DapperProductAllInfo>> GetAllProductsInfo()
        {
            var sql = @"
Select P.Id
	 , P.Name
	 , P.Descricao
	 , PT.Name      As ProductTypeName
	 , P.Qtd
	 , P.Price
  from Products		P
  Join ProductTypes	PT On P.ProductTypeId = PT.Id";

            var result = await QueryAsync<DapperProductAllInfo>(sql);
            return result;
        }
        #endregion
    }
}
