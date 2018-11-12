using CalcTest.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.WebApi.Controllers
{

    [TestClass]
    public class CalculaJurosControllerUnitTest : BaseUnitTest
    {

        [TestMethod]
        public void Get_Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var calculadoraFinanceiraService = serviceProvider.GetService<ICalculadoraFinanceiraService>();
            var calculaJurosController = new CalculaJurosController(calculadoraFinanceiraService);
            //Act
            var resultado = calculaJurosController.Get(100, 5).Value;
            //Assert
            Assert.AreEqual(resultado, "105,10");
        }

    }
}
