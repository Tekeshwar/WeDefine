using App.OrderService.API.ActionFilter;
using App.OrderService.API.DTOs;
using App.OrderService.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.OrderService.API.Controllers
{
    [SwaggerTag("Orders")]
    public class OrderController : ApplicationBaseController
    {
        private readonly IMediator _mediatR;
        public OrderController(IMediator mediator)
        {
            _mediatR = mediator;
        }

        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="createOrder"></param>
        /// <returns></returns>
        [HttpPost(Name = "CreateOrder")]
        [ProducesResponseType(typeof(Int32), 201)]
        [ProducesResponseType(typeof(ErrorResponseDto), 400)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest createOrder)
        {
            var orderid = await _mediatR.Send(createOrder);
            return Ok(orderid);
        }

        /// <summary>
        /// Get ordrs
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet("GetOrder/{orderId}")]
        [ProducesResponseType(typeof(GetOrdersDto), 200)]
        [ProducesResponseType(typeof(ErrorResponseDto), 400)]       
        [ValidateRange("orderId", 1, 100)]
        public async Task<IActionResult> GetOrder([FromRoute,] int orderId)
        {
            //var orderid = await _mediatR.Send(orderId);
            //return Ok(orderid);
            return null;
        }
    }
}
