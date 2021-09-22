using Microsoft.AspNetCore.Mvc;

namespace HFinAPI.Controllers
{
    // [Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class CheckController : ControllerBase
    {

        [HttpGet]
        public JsonResult Get() => new JsonResult(new { success = true, message = "This Web API is running." });

    }
}
