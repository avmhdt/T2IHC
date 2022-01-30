using API_IHC.Entities;
using API_IHC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly ILogger<RelatorioController> _logger;
        private readonly InMemRelatorioRepository relatorioRepository;

        public RelatorioController(ILogger<RelatorioController> logger)
        {
            this._logger = logger;
            this.relatorioRepository = new InMemRelatorioRepository();
        }

        [HttpGet]
        public IEnumerable<Relatorio> GetAllRelatorios()
        {
            return this.relatorioRepository.GetRelatorios();
        }

        [HttpGet]
        public Relatorio GetRelatorioById(int id)
        {
            return this.relatorioRepository.GetRelatorioById(id);
        }
    }
}
