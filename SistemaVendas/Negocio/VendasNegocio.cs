namespace SistemaVendas
{
  public class VendasNegocio
  {
    private IVendasRepositorio _vendasRepository;

    public VendasNegocio(IVendasRepositorio vendasRepositorio)
    {
      this._vendasRepository = vendasRepositorio;
    }

    public decimal CalcularMediaMensal(short mes, short ano)
    {
      var vendas = this._vendasRepository.BuscarVendas(mes, ano);

      var vendasMensal = vendas.Sum(s => s.Valor) / vendas.Count();

      return Math.Round(vendasMensal, 2);
    }

  }
}