namespace API_IHC.Entities
{
    public class Relatorio
    {
        public int Id { get; set; } = 0;
        public DateTime DataEntrega { get; set; } = DateTime.Now;
        public string DataEnvio { get; set; } = null;
        public string Situacao { get; set; } = "";
    }
}
