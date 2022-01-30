namespace API_IHC.Entities
{
    public class Relatorio
    {
        public int Id { get; set; }
        public DateTime DataEnvio { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Situacao { get; set; }
    }
}
