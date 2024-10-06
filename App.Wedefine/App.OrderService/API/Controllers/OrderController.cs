using App.CommanLib.ActionFilters;
using App.CommanLib.DTOs;
using App.OrderService.API.Models.Requests;
using App.OrderService.API.Models.Responses;
using App.OrderService.Application.Features.Orders.Commands;
using App.OrderService.Application.Features.Orders.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.OrderService.API.Controllers
{
    [SwaggerTag("Orders")]
    public class OrderController : ApplicationBaseController
    {        
        public OrderController(IMediator mediator):base(mediator) { }
       
        [HttpGet("GetOrder/{orderId}")]
        [ValidateRange("orderId", 1, 100)]
        [ProducesResponseType(typeof(GetOrderResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponseDto), 400)]
        public async Task<IActionResult> GetOrderById(Guid orderId)
        {
            // Send the GetOrderByIdQuery to the MediatR pipeline
            var query = new GetOrderByIdQuery(orderId);
            var result = await _mediatR.Send(query);

            if (result == null)
            {
                return NotFound();  // Return 404 if the order is not found
            }

            return Ok(result);  // Return the order data
        }


        /// <summary>
        /// Create new order
        /// </summary>
        /// <param name="createOrder"></param>
        /// <returns></returns>
        [HttpPost(Name = "CreateOrder")]
        [ProducesResponseType(typeof(CreateOrderResponse), 201)]
        [ProducesResponseType(typeof(ErrorResponseDto), 400)]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequest request)
        {
            var response = await _mediatR.Send(new CreateOrderCommand { OrderRequest = request });
            return Ok(response);
        }
    }
}
