using MassTransit;
using ProductManagement.MessageContracts;
using ProductManagement.MessageContracts.Constants;
using ProductManagement.MessageContracts.Consumers;

namespace ProductManagement.Registration
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var bus = BusConfigurator.ConfigureBus(factory =>
            {
                factory.ReceiveEndpoint(RabbitMqConstants.RegistrationServiceQueue, conf =>
                {
                    conf.Consumer<ProductRegistrationCommandConsumer>();
                });
            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}