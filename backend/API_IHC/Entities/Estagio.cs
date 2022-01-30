using System;

namespace API_IHC.Entities
{
    public class Estagio
    {
        public int Id { get; set; }
        public string Empresa { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now;
        public Relatorio Relatorio { get; set; }
        public Coordenador Coordenador { get; set; }
        public double ValorBolsa { get; set; }
        public int HorasSemanais { get; set; }

        public Estagio()
        {
            Coordenador = new Coordenador();
            Coordenador.Nome = "André Luiz De Oliveira";
        }
    }
}
