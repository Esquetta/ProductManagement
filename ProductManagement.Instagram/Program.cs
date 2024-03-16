using MassTransit;
using ProductManagement.MessageContracts;
using ProductManagement.MessageContracts.Constants;
using ProductManagement.MessageContracts.Consumers;

namespace ProductManagement.Instagram
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMqConstants.InstagramServiceQueue, conf =>
                {
                    conf.Consumer<ProductInstagramEventConsumer>();
                });
            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}