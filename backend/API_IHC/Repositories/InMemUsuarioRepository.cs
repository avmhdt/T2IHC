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
            coordenador = new Coordenador();
            coordenador.Nome = "Platão"; coordenador.Siape = "98765";
            
            var aluno1 = new Aluno(); aluno1.Nome = "Mario"; aluno1.Matricula = "2020"; aluno1.Curso = "Engenharia Mecânica"; aluno1.TipoUsuario = Usuario.Aluno;
            var aluno2 = new Aluno(); aluno2.Nome = "Lara Croft"; aluno2.Matricula = "1996"; aluno2.Curso = "Historia"; aluno2.TipoUsuario = Usuario.Aluno;
            
            alunos.Add(aluno1);
            alunos.Add(aluno2);
        }

    }
}
