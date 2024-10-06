﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.OrderService.API.Controllers
{
    [Route("api/[controller]")]
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
 