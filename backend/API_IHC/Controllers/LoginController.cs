using API_IHC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<EstagioController> _logger;

        public LoginController(ILogger<EstagioController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            var display = UsuariosValidos().Where(m => m.Usuario == login.Usuario && m.Senha == login.Senha).FirstOrDefault();
            if (display != null)
            {
                return Redirect("/Home");
            }
            else
            {
                return Redirect("/Login/Error");
            }
        }

        [HttpGet]
        public List<Login> UsuariosValidos()
        {
            List<Login> listaUsuariosValidos = new List<Login>();
            listaUsuariosValidos.Add(new Login { Usuario = "siape", Senha = "senha1" });
            listaUsuariosValidos.Add(new Login { Usuario = "matricula", Senha = "senha2" });
            listaUsuariosValidos.Add(new Login { Usuario = "user3", Senha = "password3" });
            return listaUsuariosValidos;
        }
    }
}
