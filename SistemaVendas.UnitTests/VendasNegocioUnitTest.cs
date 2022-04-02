using Xunit;
using SistemaVendas;
using Moq;
using System;
using System.Collections.Generic;

namespace SistemaVendas.UnitTests
{
  
  public class VendasNegocioUnitTest
  {
    VendasNegocio _vendasNegocio;
    Mock<IVendasRepositorio> _vendasRepositorioMock;

    public VendasNegocioUnitTest()
    {
      var returnList = new List<Vendas>
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

      this._vendasRepositorioMock = new Mock<IVendasRepositorio>();
      this._vendasRepositorioMock.Setup(x => 
        x.BuscarVendas(It.IsAny<short>(), It.IsAny<short>())
      ).Returns(returnList);

      this._vendasNegocio = new VendasNegocio(this._vendasRepositorioMock.Object);
    }
    
    [Fact(DisplayName = "Deve Calcular Media Mensal Com Sucesso")]
    public void DeveCalcularMediaMensalComSucesso()
    {
      var valorMensal = this._vendasNegocio.CalcularMediaMensal(4, 2022);

      Assert.Equal(550.00m, valorMensal);
    }

  }

}
