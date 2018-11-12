using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.Core.Domains
{
    [TestClass]
    public class CalculadoraServiceUnitTest : BaseUnitTest
    {
        [TestMethod]
        public void Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var calculadoraService = serviceProvider.GetService<ICalculadoraService>();
            Calculo calculo = new Calculo(100, 5);
            //Act
            calculo = calculadoraService.CalculaJurosComposto(calculo);
            //Assert
            Assert.AreEqual(calculo.ToString(), "105,10");
        }

    }
}
