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
            loginRepository = new InMemLoginRepository();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            var loginTry = loginRepository.DoLogin(login.Usuario, login.Senha); 
            if (loginTry)
            {
                var tipoUsuario = loginRepository.GetTipoUsuario(login.Usuario);
                if (tipoUsuario == Usuario.Aluno)
                {
                    Redirect("/Home/Aluno");
                    return new OkObjectResult(login);

                }
                else
                    Redirect("/Home/Coord");
                     return new OkObjectResult(login);
            }   
            else
            {
               return Redirect("/Login/Error");
            }
        }
    }
}
