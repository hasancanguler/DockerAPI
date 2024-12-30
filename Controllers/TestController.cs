using Microsoft.AspNetCore.Mvc;

namespace FirstDockerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "Test")]
        public string Get()
        {
            return "Test Ok";
        }
    }
}
