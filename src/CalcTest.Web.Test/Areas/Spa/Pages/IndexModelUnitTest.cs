using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.Web.Areas.Spa.Pages
{
    [TestClass]
    public class IndexModelUnitTest
    {
        [TestMethod]
        public void Quando_Executado_cria_instancia_classe_IndexModel()
        {
            //Arrange
            var pageModel = new IndexModel();
            //Act
            var item = pageModel;
            //Assert
            Assert.IsNotNull(item);
        }

    }
}
