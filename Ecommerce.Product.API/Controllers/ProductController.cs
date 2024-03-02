using Ecommerce.Product.Application.Product;
using Ecommerce.Product.Application.Product.Dto;
using Ecommerce.Product.CrossCutting.Exception;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Product.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
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

        //[HttpGet("GetAllProducts")]
        //public async Task<IActionResult> GetAllProducts([FromQuery] string responseContentType = "application/x-protobuf")
        //{
        //    var result = await _productService.GetAllProducts();
        //    if (result == null)
        //        return NotFound();

        //    //return Ok(result);
        //    if ("application/x-protobuf".Equals(responseContentType))
        //    {
        //        var protobufResult = ConvertToProtobufObject(result);
        //        return ProtobufFile(protobufResult);
        //    }
        //    else if ("application/json".Equals(responseContentType)) // any other is json
        //    {
        //        return Ok(result);
        //    }
        //    else
        //    {
        //        throw new BusinessException($"Unkown responseContentType='{responseContentType}'. Supported types are application/x-protobuf, application/json.");
        //    }
        //}

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
