using Microsoft.VisualStudio.TestTools.UnitTesting;
using Softplan_CalculaJuros.Services.JurosService.cs;

namespace CalculaJuros.Text
{
    [TestClass]
    public class CalculaJurosTest
    {
        [TestMethod]
        public void CalculaJuros_VerificaCalculo()
        {
            var jurosService = new JurosService();
            var valorInicial = 100;
            var tempo = 5;

            var resultado = jurosService.CalculaJuros(valorInicial, tempo);

            Assert.AreEqual(105.1, resultado);
        }

        [TestMethod]
        public void CalculaJuros_VerificaUrl()
        {
            var jurosService = new JurosService();
            var resultado = jurosService.GetUrl();

            Assert.AreEqual("", resultado);
        }
    }
}
