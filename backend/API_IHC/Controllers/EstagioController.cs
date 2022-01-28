using API_IHC.Entities;
using API_IHC.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_IHC.Controllers
{
    [Route("api/[controller]")]
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



    }
}
