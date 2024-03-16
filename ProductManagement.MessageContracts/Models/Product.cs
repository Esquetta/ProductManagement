using ProductManagement.MessageContracts.Commands;
using ProductManagement.MessageContracts.Events;

namespace ProductManagement.MessageContracts.Models
{
    public class Product : IProductRegistrationCommand,IProductEvent
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }

    }
}
