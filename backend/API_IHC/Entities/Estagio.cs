using System;

namespace API_IHC.Entities
{
    public class Estagio
    {
        public int Id { get; set; }
        public string Empresa { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } = DateTime.Now;
        public DateTime DataFim { get; set; } = DateTime.Now;
        public Relatorio? Relatorio { get; set; }
        public Coordenador Coordenador { get; }
        public double ValorBolsa { get; set; }
        public int HorasSemanais { get; set; }
        public string NomeAluno { get; set; }
        public string Usuario { get; set; }
        public Estagio()
        {
            Coordenador = new Coordenador();
            Coordenador.Nome = "Andre Luiz De Oliveira";
        }
    }
}
