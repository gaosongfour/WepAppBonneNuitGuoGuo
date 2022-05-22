using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppBonneNuitGuoGuo.WebAPI.Models.Tests;

namespace WebAppBonneNuitGuoGuo.WebAPI.Controllers.Tests
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("whoami")]
        public ActionResult<WhoAmIResponse> WhoAmI()
        {
            var response = new WhoAmIResponse { UserId = "456433", UserName = "Song" };

            return Ok(response);
        }
    }
}
