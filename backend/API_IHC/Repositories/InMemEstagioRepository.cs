
using API_IHC.Entities;
using System.Linq;

namespace API_IHC.Repositories
{
    public class InMemEstagioRepository
    {
        private readonly List<Estagio> estagios;
        private readonly InMemUsuarioRepository usuarioRepository;

        public InMemEstagioRepository()
        {
            this.estagios = new List<Estagio>();
            estagios.Add(new Estagio() { Id = 001, Empresa = "Nintendo", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddMonths(12)}); 
            estagios.Add(new Estagio() { Id = 002, Empresa = "Sony", DataInicio = DateTime.Now, DataFim = DateTime.Now.AddMonths(6) });
        }

        public IEnumerable<Estagio> GetEstagios()
        {
            return estagios.ToList();
        }

        public Estagio GetEstagioById(int id)
        {
            return estagios.Where(estagio => estagio.Id == id).SingleOrDefault();
        }

        public bool CadastrarEstagio(Estagio estagio)
        {
            if (estagio != null)
            {
                estagios.Add(estagio);
                return true;
            }
            else
                return false;
        }

        public bool FinalizarEstagio(int id)
        {
            var estagio = estagios.Where(estagio => estagio.Id == id).SingleOrDefault();
            if (estagio != null)
            {
                estagios.Remove(estagio);
                return true;
            }
            else
                return false;
        }

        public void UpdateEstagio(int id, DateTime novaDataFim)
        {
            var estagio = estagios.Where(estagio => estagio.Id == id).SingleOrDefault();
            estagio.DataFim = novaDataFim;
        }
    }
}
