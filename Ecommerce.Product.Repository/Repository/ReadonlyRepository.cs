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
        public async Task<IEnumerable<DapperProduct>> GetAllProducts()
        {
            var sql = @"
Select Id
     , Nome
     , Login
     , Password
     , Email
  From Products";

            var result = await QueryAsync<DapperProduct>(sql);
            return result;
        }
        #endregion
    }
}
