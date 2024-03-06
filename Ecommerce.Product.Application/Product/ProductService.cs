using AutoMapper;
using Ecommerce.Product.Application.Product.Dto;
using Ecommerce.Product.Application.Shared;
using Ecommerce.Product.Domain.Entity.Product.Repository;
using Ecommerce.Product.Domain.Entity.Readonly.Repository;

namespace Ecommerce.Product.Application.Product
{
    public class ProductService : AbstractService, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IReadonlyRepository _readonlyRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper, IReadonlyRepository readonlyRepository)
            : base(mapper)
        {
            _productRepository = productRepository;
            //_mapper = mapper;
            _readonlyRepository = readonlyRepository;
        }
        public async Task<ProductDto> GetProduct(int ProductId)
        {
            var result = await _productRepository.GetOneByCriteria(a => a.Id == ProductId);
            return _mapper.Map<ProductDto>(result);
        }
        public async Task<List<ProductAllInfoDto>> GetAllProductsInfo()
        {
            var result = await _readonlyRepository.GetAllProductsInfo();
            return _mapper.Map<List<ProductAllInfoDto>>(result);
        }
        public async Task<ProductDto> UpdateQtdProduct(int productId, int qtdProduct)
        {
            using (var transaction = await _productRepository.CreateTransaction())
            {
                try
                {
                    var product = await _productRepository.GetOneByCriteria(a => a.Id == productId);

                    if (product == null)
                        throw new System.Exception($"Produto não encontrado. Favor verificar!");

                    product.Qtd -= qtdProduct;

                    var productDto = _mapper.Map<ProductDto>(product);

                    var result = await SaveUpdateDeleteDto(productDto, _productRepository);

                    await transaction.CommitAsync();

                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        public async Task<ProductDto> SaveProduct(ProductDto ProductDto)
        {
            using (var transaction = await _productRepository.CreateTransaction())
            {
                try
                {
                    //if (!ProductDto.Created.HasValue)
                    //    Created.Created = DateTime.Now;

                    var result = await SaveUpdateDeleteDto(ProductDto, _productRepository);

                    await transaction.CommitAsync();

                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
        }
        public async Task<bool> DeleteProduct(int ProductdId)
        {
            using (var transaction = await _productRepository.CreateTransaction())
            {
                try
                {
                    var Product = await _productRepository.GetOneByCriteria(a => a.Id == ProductdId);

                    await _productRepository.Delete(Product);

                    await transaction.CommitAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw ex;
                }
            }
        }
    }
}
