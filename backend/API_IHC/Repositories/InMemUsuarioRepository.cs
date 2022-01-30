using API_IHC.Entities;

namespace API_IHC.Repositories
{
    public class InMemUsuarioRepository
    {
        private readonly List<Aluno> alunos;
        private readonly Coordenador coordenador;
        private readonly InMemEstagioRepository estagioRepository;

        public InMemUsuarioRepository()
        {
            alunos = new List<Aluno>();
            estagioRepository = new InMemEstagioRepository();

            coordenador = new Coordenador();
            coordenador.Nome = "Platão"; coordenador.Siape = "98765";
            
            var aluno1 = new Aluno(); aluno1.Nome = "Mario"; aluno1.Matricula = "2020"; aluno1.Curso = "Engenharia Mecânica"; aluno1.TipoUsuario = Usuario.Aluno;
            aluno1.Estagio = estagioRepository.estagios[0];
            var aluno2 = new Aluno(); aluno2.Nome = "Lara Croft"; aluno2.Matricula = "1996"; aluno2.Curso = "Historia"; aluno2.TipoUsuario = Usuario.Aluno;
            aluno2.Estagio = estagioRepository.estagios[1];

            alunos.Add(aluno1);
            alunos.Add(aluno2);
        }

        public IEnumerable<Aluno> GetAlunos()
        {
            return alunos.ToList();
        }

        public Aluno GetAlunoByUsername(string username)
        {
            return alunos.Where(aluno => aluno.Usuario == username).SingleOrDefault();
        }
    }
}
