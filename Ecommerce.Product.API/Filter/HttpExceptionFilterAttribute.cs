namespace Ecommerce.Product.API.Filter
{
    public class HttpExceptionFilterAttribute
    {
        private readonly ILogger _logger;
        public HttpExceptionFilterAttribute(ILogger<HttpExceptionFilter> logger)
        {
            _logger = logger;
        }
    }
}
