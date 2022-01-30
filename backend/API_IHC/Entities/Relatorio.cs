namespace API_IHC.Entities
{
    public class Relatorio
    {
        public int Id { get; set; }
        public DateTime DataEntrega { get; set; }
        public string DataEnvio { get; set; } = null;
        public string Situacao { get; set; }
    }
}
