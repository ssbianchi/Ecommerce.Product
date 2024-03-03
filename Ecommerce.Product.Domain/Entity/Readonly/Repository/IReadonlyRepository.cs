using Ecommerce.Product.Domain.Entity.Readonly.Dapper.Product;

namespace Ecommerce.Product.Domain.Entity.Readonly.Repository
{
    public interface IReadonlyRepository
    {
        #region User
        Task<IEnumerable<DapperProductAllInfo>> GetAllProductsInfo();
        #endregion
    }
}

