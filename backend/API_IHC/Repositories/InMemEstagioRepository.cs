
using API_IHC.Entities;
using System.Linq;

namespace API_IHC.Repositories
{
    public class InMemEstagioRepository
    {
        private readonly List<Estagio> estagios;

        public InMemEstagioRepository()
        {
            var aluno1 = new Aluno(); aluno1.Nome = "Mario"; aluno1.Matricula = "2020"; aluno1.Curso = "Engenharia Mecânica"; aluno1.TipoUsuario = Usuario.Aluno;
            var aluno2 = new Aluno(); aluno2.Nome = "Lara Croft"; aluno2.Matricula = "1996"; aluno2.Curso = "Historia"; aluno2.TipoUsuario = Usuario.Aluno;

            this.estagios = new List<Estagio>();
            estagios.Add(new Estagio() { Id = 001, Empresa = "Nintendo", DataInicio = DateTime.Now, Aluno = aluno1 });
            estagios.Add(new Estagio() { Id = 002, Empresa = "Sony", DataInicio = DateTime.Now, Aluno = aluno2 });
        }

        public IEnumerable<Estagio> GetEstagios()
        {
            return estagios.ToList();
        }

        public Estagio GetEstagio(int id)
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
    }
}
