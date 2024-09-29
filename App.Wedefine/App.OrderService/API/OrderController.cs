using App.OrderService.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.OrderService.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public OrderController(IMediator mediator)
        {
            _mediatR = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest createOrder)
        {
            var orderid = await _mediatR.Send(createOrder);
            return Ok(orderid);
        }
    }
}
