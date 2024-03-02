using Ecommerce.Product.Application.Product.Dto;

namespace Ecommerce.Product.Application.Product
{
    public interface IProductService
    {
        Task<ProductDto> GetProduct(int ProductId);
        Task<List<ProductDto>> GetAllProducts();
        Task<ProductDto> SaveProduct(ProductDto ProductDto);
        Task<bool> DeleteProduct(int ProductdId);
    }
}
