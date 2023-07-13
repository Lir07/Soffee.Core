using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Soffee.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello");
    }
}
