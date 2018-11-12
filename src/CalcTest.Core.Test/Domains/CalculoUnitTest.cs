using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest.Core.Domains
{
    [TestClass]
    public class CalculoUnitTest : BaseUnitTest
    {
        [TestMethod]
        public void Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            Calculo calculo = new Calculo(100, 5);
            //Act
            calculo.Calcula(0.01);
            //Assert
            Assert.AreEqual(calculo.ToString(), "105,10");
        }

    }
}
