namespace SistemaVendas
{
  public class Program
  {
    public static void Main(string[] ars)
    {
      var valorMediaMensal = new VendasNegocio(new VendasRepositorio())
        .CalcularMediaMensal(4, 2022);
      
      Console.WriteLine($"Valor Médio de Vendas no Mês: {valorMediaMensal}");
    }
  }
}