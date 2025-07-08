using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using AppNegocio;


namespace UnitTestCapas
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCalcularY()

        {
            double x = 2;
            double y = 0;
            double resultadoEsperado = 14;


            AppNegocio.Negocio negocio = new AppNegocio.Negocio();
            y = negocio.CalcularY(x);

            Assert.AreEqual(resultadoEsperado, y);

        }
    }
}
