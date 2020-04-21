using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blog.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComBaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> logger;
        public ComBaseController(ILogger<T> logger)
        {
            this.logger = logger;
        }
    }
}