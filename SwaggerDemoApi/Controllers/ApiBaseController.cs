using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerDemoApi.Controllers
{
    [ApiController]
    [Route("Api/[controller]/[action]")]
    public class ApiBaseController : ControllerBase
    {
    }
}
