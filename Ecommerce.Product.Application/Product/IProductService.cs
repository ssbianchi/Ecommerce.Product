using Ecommerce.Product.Application.Product.Dto;

namespace Ecommerce.Product.Application.Product
{
    public interface IProductService
    {
        Task<ProductDto> GetProduct(int ProductId);
        Task<List<ProductAllInfoDto>> GetAllProductsInfo();
        Task<ProductDto> UpdateQtdProduct(int productId, int qtdProduct);
        Task<ProductDto> SaveProduct(ProductDto ProductDto);
        Task<bool> DeleteProduct(int ProductdId);
    }
}
