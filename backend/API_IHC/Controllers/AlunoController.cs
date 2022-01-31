using API_IHC.Entities;
using API_IHC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly InMemUsuarioRepository usuarioRepository;

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
            usuarioRepository = new InMemUsuarioRepository();
        }

        [HttpGet]
        public IEnumerable<Aluno> GetAlunosTeste()
        {
            return this.usuarioRepository.GetAlunos();
        }

        [HttpGet]
        public Aluno GetAlunoByUsername(string username)
        {
            return this.usuarioRepository.GetAlunoByUsername(username);
        }
    }
}
