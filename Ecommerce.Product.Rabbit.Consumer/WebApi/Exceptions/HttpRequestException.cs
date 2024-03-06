using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Product.Rabbit.Consumer.WebApi.Exceptions
{
    public sealed class HttpRequestException : Exception
    {
        public HttpRequestException() { }
        public HttpRequestException(string errorMessage) : base(errorMessage) { }
        public HttpRequestException(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
    }
}
