using API_IHC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Index()
        {

        }
    }
}