using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok("testanto Get");
        }
    }
}
