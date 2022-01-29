using API_IHC.Entities;
using API_IHC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EstagioController : ControllerBase
    {
        private readonly ILogger<EstagioController> _logger;
        private readonly InMemEstagioRepository estagioRepository;

        public EstagioController(ILogger<EstagioController> logger)
        {
            _logger = logger;
            estagioRepository = new InMemEstagioRepository();
        }

        [HttpGet]
        public IEnumerable<Estagio> GetEstagios()
        {
            return this.estagioRepository.GetEstagios();
        }

        [HttpGet]
        public Estagio GetEstagioById(int id)
        {
            return this.estagioRepository.GetEstagioById(id);
        }

        [HttpPost]
        public bool CadastrarEstagio(Estagio estagio)
        {
            return this.estagioRepository.CadastrarEstagio(estagio);
        }

        [HttpPost]
        public bool FinalizarEstagio(int id)
        {
            return this.estagioRepository.FinalizarEstagio(id);
        }

        [HttpPost]
        public void UpdateEstagio(int id, DateTime novaDataFim)
        {
            this.estagioRepository.UpdateEstagio(id, novaDataFim);
        }

    }
}
