using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.ProductService.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApplicationBaseController : ControllerBase
    {
        protected readonly IMediator _mediatR;
        public ApplicationBaseController(IMediator mediator)
        {
            _mediatR = mediator;
        }
    }
}
