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
        public async Task<IActionResult> Login(string usuario, string senha)
        {
            var response = loginRepository.DoLogin(usuario, senha); 
            if (response)
            {
                var tipoUsuario = loginRepository.GetTipoUsuario(usuario);
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
