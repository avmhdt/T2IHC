namespace API_IHC.Entities
{
    public class Aluno : Login
    {
        public string Nome { get; set; } = string.Empty;
        public string Matricula { get; set; } = string.Empty;
        public string Curso { get; set; } = string.Empty;
        public Estagio Estagio { get; set; }

        public Aluno()
        {

        }

    }
}