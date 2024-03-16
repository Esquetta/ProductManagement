using MassTransit;
using ProductManagement.MessageContracts.Events;

namespace ProductManagement.MessageContracts.Consumers
{
    public class ProductNotificationEventConsumer : IConsumer<IProductEvent>
    {
        public async Task Consume(ConsumeContext<IProductEvent> context)
        {
            Console.WriteLine($"{context.Message.ProductName} isimli ürün yayınlanarak müşteriler bilgilendirilmiştir.");
        }
    }

}
