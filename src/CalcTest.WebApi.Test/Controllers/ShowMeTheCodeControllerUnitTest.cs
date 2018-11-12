using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.WebApi.Controllers
{
    [TestClass]
    public class ShowMeTheCodeControllerUnitTest : BaseWebApiUnitTest
    {

        [TestMethod]
        public void Get_Quando_Executado_Retorna_Url_Fonte_Github()
        {
            //Arrange
            var calculaJurosController = new ShowMeTheCodeController();
            //Act
            var resultado = calculaJurosController.Get().Value;
            //Assert
            Assert.AreEqual(resultado, "https://github.com/robertosistemas/CalcTest");
        }

    }

}
