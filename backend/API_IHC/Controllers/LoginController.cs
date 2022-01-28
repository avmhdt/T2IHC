using API_IHC.Entities;
using API_IHC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<EstagioController> _logger;
        private readonly InMemLoginRepository loginRepository;

        public LoginController(ILogger<EstagioController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            var response = loginRepository.DoLogin(login); 
            if (response != true)
            {
                var tipoUsuario = loginRepository.GetUsuario(login);
                if (tipoUsuario == Usuario.Aluno)
                    return Redirect("/Home/Aluno");
                else
                    return Redirect("/Home/Coord");
            }
            else
            {
                return Redirect("/Login/Error");
            }
        }
    }
}
