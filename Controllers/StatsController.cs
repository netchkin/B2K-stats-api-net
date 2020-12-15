using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace todo_dotnet.Controllers
{
    [ApiController]
    [Route("stats")]
    public class StatsController : ControllerBase
    {
        private readonly ILogger<StatsController> _logger;

        public StatsController(ILogger<StatsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { todosCreated = "42", todosCompleted = "2", todosDeleted = "13" });
        }
    }
}
