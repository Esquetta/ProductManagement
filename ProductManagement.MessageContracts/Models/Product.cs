using ProductManagement.MessageContracts.Commands;

namespace ProductManagement.MessageContracts.Models
{
    public class Product : IProductRegistrationCommand
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }

    }
}
