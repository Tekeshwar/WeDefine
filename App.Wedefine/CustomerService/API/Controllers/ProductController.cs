using App.CommanLib.ActionFilters;
using App.CommanLib.DTOs;
using App.ProductService.API.DTOs;
using App.ProductService.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.ProductService.API.Controllers
{

    public class ProductController : ApplicationBaseController
    {

        public ProductController(IMediator mediator) : base(mediator) { }


        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest request)
        {
            var productId = await _mediatR.Send(request);
            return Ok(productId);
        }

        /// <summary>
        /// Get ordrs
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("GetProduct/{productId}")]
        [ProducesResponseType(typeof(GetProductDto), 200)]
        [ProducesResponseType(typeof(ErrorResponseDto), 400)]
        [ValidateRange("productId", 1, 100)]
        public async Task<IActionResult> GetProduct([FromRoute,] int productId)
        {
            //var orderid = await _mediatR.Send(orderId);
            //return Ok(orderid);
            return null;
        }

    }
}
