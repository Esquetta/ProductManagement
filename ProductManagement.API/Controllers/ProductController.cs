using Microsoft.AspNetCore.Mvc;
using ProductManagement.MessageContracts;
using ProductManagement.MessageContracts.Commands;
using ProductManagement.MessageContracts.Constants;
using ProductManagement.MessageContracts.Models;

namespace ProductManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMqConstants.RabbitMqUri}/{RabbitMqConstants.RegistrationServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IProductRegistrationCommand>(product);
            return Ok();
        }
    }
}
