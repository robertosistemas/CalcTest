using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalcTest.Web.Services
{

    [TestClass]
    public class CalculadoraHttpServiceUnitTest
    {

        [TestMethod]
        public async Task Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var srv = new CalculadoraHttpServiceFake();
            //Act
            var item = await srv.CalcularJurosAsync(100, 5);
            //Assert
            Assert.AreEqual(item, "105,10");
        }

    }

}
