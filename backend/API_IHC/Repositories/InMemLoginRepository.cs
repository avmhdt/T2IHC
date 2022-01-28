using API_IHC.Entities;

namespace API_IHC.Repositories
{
    public class InMemLoginRepository
    {
        public List<Login> UsuariosValidos()
        {
            List<Login> listaUsuariosValidos = new List<Login>();
            listaUsuariosValidos.Add(new Login { Usuario = "coord", Senha = "coord1", TipoUsuario = Usuario.Coordenador });
            listaUsuariosValidos.Add(new Login { Usuario = "aluno1", Senha = "aluno1", TipoUsuario = Usuario.Aluno });
            listaUsuariosValidos.Add(new Login { Usuario = "aluno2", Senha = "aluno2", TipoUsuario = Usuario.Aluno });
            return listaUsuariosValidos;
        }

        public bool DoLogin(Login login)
        {
            var loginValido = UsuariosValidos().Where(m => m.Usuario == login.Usuario && m.Senha == login.Senha).FirstOrDefault();
            if (loginValido != null)
                return true;
            else
                return false;
        }

        public Usuario GetUsuario(Login login)
        {
            if (login.TipoUsuario == Usuario.Aluno)
                return Usuario.Aluno;
            else
                return Usuario.Coordenador;
        }
    }
}
