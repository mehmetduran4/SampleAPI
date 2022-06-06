using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Controllers.DefaultController
{
    [Route("")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public DefaultController()
        {

        }

        [Route("/")]
        [HttpGet]
        public string Default()
        {
            return $"Sample API";
        }
    }
}
