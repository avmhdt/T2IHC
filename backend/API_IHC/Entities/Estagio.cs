using System;

namespace API_IHC.Entities
{
    public class Estagio
    {
        public Guid Id { get; set; }
        public string Empresa { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataFim { get;} = DateTime.Now;
        public Aluno Aluno { get; set; }

        public Estagio()
        {
            this.Id = new Guid();
            this.Aluno = new Aluno();
        }
    }
}
