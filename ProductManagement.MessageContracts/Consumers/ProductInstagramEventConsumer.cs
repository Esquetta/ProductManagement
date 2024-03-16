using MassTransit;
using ProductManagement.MessageContracts.Events;

namespace ProductManagement.MessageContracts.Consumers
{
    public class ProductInstagramEventConsumer : IConsumer<IProductEvent>
    {
        public async Task Consume(ConsumeContext<IProductEvent> context)
        {
            Console.WriteLine($"{context.Message.ProductName} isimli ürün Instagram'da yayınlanmıştır.");
        }
    }
}
