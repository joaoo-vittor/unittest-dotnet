namespace SistemaVendas
{
  public class VendasRepositorio : IVendasRepositorio
  {
    public IList<Vendas> BuscarVendas(short mes, short ano)
    {
      return new List<Vendas>
      {
        new Vendas
        {
          Data = new DateTime(2022, 4, 2),
          Valor = 500.00m,
        },
        new Vendas
        {
          Data = new DateTime(2022, 5, 2),
          Valor = 600.00m,
        },
      };
    }
  }
}