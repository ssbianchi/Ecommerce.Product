using Ecommerce.Product.Application.Product;
using Ecommerce.Product.Application.Product.Dto;
using Ecommerce.Product.CrossCutting.Exception;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Product.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        #region Web API Methods
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(int ProductId)
        {
            var result = await _productService.GetProduct(ProductId);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet("GetAllProductsInfo")]
        public async Task<IActionResult> GetAllProductsInfo()
        {
            var result = await _productService.GetAllProductsInfo();
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost("UpdateQtdProduct")]
        public async Task<IActionResult> UpdateQtdProduct(int productId, int qtdProduct)
        {
            _logger.LogInformation("Alterando quantidade do produto");
            var result = await _productService.UpdateQtdProduct(productId, qtdProduct);

            if (result == null)
                return NotFound();

            return Created($"/{result.Id}", result);
        }

        [HttpPost("SaveProduct")]
        public async Task<IActionResult> SaveProduct([FromBody] ProductDto ProductDto)
        {
            var result = await _productService.SaveProduct(ProductDto);

            if (result == null)
                return NotFound();

            return Created($"/{result.Id}", result);
        }
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DelteProduct(int ProductId)
        {
            var result = await _productService.DeleteProduct(ProductId);
            if (!result)
                return NotFound();

            return Ok(result);
        }
        #endregion
    }
}
