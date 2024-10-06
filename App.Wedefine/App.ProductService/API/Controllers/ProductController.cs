using App.CommanLib.DTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace App.ProductService.API.Controllers
{
    [SwaggerTag("Products")]
    public class ProductController : ApplicationBaseController
    {
        public ProductController(IMediator mediator) : base(mediator) { }

        ///// <summary>
        ///// Create new Product
        ///// </summary>
        ///// <param name="createProduct"></param>
        ///// <returns></returns>
        //[HttpPost(Name = "CreateProduct")]
        //[ProducesResponseType(typeof(Int32), 201)]
        //[ProducesResponseType(typeof(ErrorResponseDto), 400)]
        //public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest createProduct)
        //{
        //    var Productid = await _mediatR.Send(createProduct);
        //    return Ok(Productid);
        //}

        ///// <summary>
        ///// Get ordrs
        ///// </summary>
        ///// <param name="ProductId"></param>
        ///// <returns></returns>
        //[HttpGet("GetProduct/{ProductId}")]
        //[ProducesResponseType(typeof(GetProductsDto), 200)]
        //[ProducesResponseType(typeof(ErrorResponseDto), 400)]
        //[ValidateRange("ProductId", 1, 100)]
        //public async Task<IActionResult> GetProduct([FromRoute,] int ProductId)
        //{
        //    //var Productid = await _mediatR.Send(ProductId);
        //    //return Ok(Productid);
        //    return null;
        //}
    }
}
