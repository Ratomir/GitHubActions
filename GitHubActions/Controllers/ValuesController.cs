using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitHubActions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult GetVersion()
        {
            return Ok(_configuration.GetValue<string>("Version"));
        }

        [Route("connection_string")]
        public IActionResult GetConnectionString()
        {
            return Ok(_configuration.GetConnectionString("MySQL"));
        }
    }
}
