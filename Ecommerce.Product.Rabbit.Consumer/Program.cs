using Ecommerce.Product.CrossCutting.Rabbit;
using Ecommerce.Product.Rabbit.Consumer.WebApi.Product;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace Ecommerce.Product.Rabbit.Consumer
{
    public class Program
    {
        private static IProductAPI _productAPI;
        static void Main(string[] args)
        {
            if (_productAPI == null)
                _productAPI = new ProductAPI();

            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest"
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "productQueue",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var json = Encoding.UTF8.GetString(body);

                    if (json == "true")
                        return;

                    RabbitMessageConsumer message = JsonSerializer.Deserialize<RabbitMessageConsumer>(json);

                    System.Threading.Thread.Sleep(1000);

                    var api = _productAPI.UpdateProduct(message.ProductId, message.Qtd);

                    Console.WriteLine($"ProductId: {message.ProductId}; Qtd={message.Qtd}");
                };
                channel.BasicConsume(queue: "productQueue",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }
    }
}

