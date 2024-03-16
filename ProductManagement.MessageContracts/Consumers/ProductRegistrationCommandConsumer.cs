using MassTransit;
using ProductManagement.MessageContracts.Commands;
using ProductManagement.MessageContracts.Events;
using ProductManagement.MessageContracts.Models;

namespace ProductManagement.MessageContracts.Consumers
{
    public class ProductRegistrationCommandConsumer : IConsumer<IProductRegistrationCommand>
    {
        public async Task Consume(ConsumeContext<IProductRegistrationCommand> context)
        {
            Console.WriteLine($"{context.Message.ProductName} isimli ürün :");
            Console.WriteLine($"Veritabanına kayıt edilmiştir.");
            Console.WriteLine($"Facebook'ta yayınlanacaktır.");
            Console.WriteLine($"Instagram'da yayınlanacaktır.");
            Console.WriteLine("*********************");

            await context.Publish<IProductEvent>(new Product
            {
                ProductName = context.Message.ProductName,
                Quantity = context.Message.Quantity
            });
        }
    }
}
