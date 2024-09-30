using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.OrderService.API.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class ApplicationBaseController : ControllerBase
    {
    }
}
