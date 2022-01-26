using System;

namespace API_IHC.Entities
{
    public class Estagio
    {
        public Guid Id { get; set; }
        public string Empresa { get; set; }
        public DateTime DataInicio{ get; set;}
        public DateTime DataFim { get;}
        public AlunoModel Aluno { get; set; }

        public Estagio()
        {
            this.Id = new Guid();
        }
    }
}
