using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.Application.Services
{
    [TestClass]
    public class CalculadoraFinanceiraServiceUnitTest: BaseUnitTest
    {
        [TestMethod]
        public void Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var calculadoraFinanceiraService = serviceProvider.GetService<ICalculadoraFinanceiraService>();
            var calculoInputDto = new CalculoInputDto(100, 5);
            //Act
            var calculoOutputDto = calculadoraFinanceiraService.CalculaJurosComposto(calculoInputDto);
            //Assert
            Assert.AreEqual(calculoOutputDto.ToString(), "105,10");
        }

    }
}
