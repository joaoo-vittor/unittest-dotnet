using Xunit;
using SistemaVendas;

namespace SistemaVendas.UnitTests
{
    public class FreteNegocioUnitTest
    {
        
        [Theory(DisplayName = "Deve calcular frete com distância até 5km com sucesso")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void DeveCalcularFreteComDistanciaAte5KmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(00.00m, valorFrete);
        }

        [Theory(DisplayName = "Deve calcular frete com distância maior que 5km a menor que 15km com sucesso")]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        public void DeveCalcularFreteComDistanciaMaiorQue5KmEMenorQue15KmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(10.00m, valorFrete);
        }

        [Theory(DisplayName = "Deve calcular frete com distância maior ou igual a 15km com sucesso")]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(21)]
        public void DeveCalcularFreteComDistanciaMaiorOuIgualA15KmComSucesso(int distanciaKm)
        {
            var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

            Assert.Equal(30.00m, valorFrete);
        }

    }
}
