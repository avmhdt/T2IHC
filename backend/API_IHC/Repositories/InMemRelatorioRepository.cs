using API_IHC.Entities;

namespace API_IHC.Repositories
{
    public class InMemRelatorioRepository
    {
        public List<Relatorio> relatorios;
        public InMemRelatorioRepository()
        {
            this.relatorios = new List<Relatorio>();
            relatorios.Add(new Relatorio { Id = 001, DataEntrega = DateTime.Now.AddMonths(1), DataEnvio = "", Situacao = "Pendente"});
            relatorios.Add(new Relatorio { Id = 002, DataEntrega = DateTime.Now.AddDays(1), DataEnvio = DateTime.Today.ToString(), Situacao = "Enviado"});

        }

        //public Relatorio GetRelatorioById(int id)
        //{

        //}
    }
}
