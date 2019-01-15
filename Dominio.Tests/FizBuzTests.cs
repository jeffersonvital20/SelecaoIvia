using Dominio;
using NUnit.Framework;

namespace Tests
{
    public class FizBuzTests
    {     
        [Test]
        public void DevoRetornarFizParaNumerosMultiplosDe3()
        {
            var fb = new FizBuz();
            var retorno = fb.Retorno(3);
            Assert.AreEqual("FIZ", retorno);
        }

        [Test]
        public void DevoRetornarBuzParaNumerosMultiplosDe5()
        {
            var fb = new FizBuz();
            var retorno = fb.Retorno(5);
            Assert.AreEqual("BUZ", retorno);
        }
        [Test]
        public void DevoRetornarFizBuzParaNumerosMultiplosDe3e5()
        {
            var fb = new FizBuz();
            var retorno = fb.Retorno(15);
            Assert.AreEqual("FIZBUZ", retorno);
        }
    }
}