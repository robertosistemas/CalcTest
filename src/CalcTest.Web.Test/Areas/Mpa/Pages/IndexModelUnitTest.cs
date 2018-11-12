using CalcTest.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CalcTest.Web.Areas.Mpa.Pages
{
    [TestClass]
    public class IndexModelUnitTest: BaseWebUnitTest
    {
        [TestMethod]
        public async Task Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var srv = new CalculadoraHttpServiceFake();
            var pageModel = new IndexModel(srv);
            //Código da competição
            pageModel.Calculo = new ViewModels.CalculoViewModel();
            pageModel.Calculo.ValorInicial = 100;
            pageModel.Calculo.Meses = 5;
            //Act
            await pageModel.OnPostAsync();
            //Assert
            Assert.AreEqual(pageModel.Calculo.Resultado, "105,10");
        }

    }
}
