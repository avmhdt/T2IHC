
using API_IHC.Entities;
using System.Linq;

namespace API_IHC.Repositories
{
    public class InMemEstagioRepository
    {
        private readonly List<Estagio> estagios;
        //private readonly Aluno aluno = new Aluno();
        //dados de teste

        public InMemEstagioRepository()
        {
            this.estagios = new List<Estagio>
            {
                new Estagio { Id = Guid.NewGuid(), Empresa = "Nintendo", DataInicio = DateTime.Now },
                new Estagio { Id = Guid.NewGuid(), Empresa = "Sony", DataInicio = DateTime.Now }

                };
            }

        public IEnumerable<Estagio> GetEstagios()
        {
            return estagios.ToList();
        }

        public Estagio GetEstagio(Guid id)
        {
            return estagios.Where(estagio => estagio.Id == id).SingleOrDefault();
        }

    }
}
