using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using NUnit.Framework;

namespace Dominio.Tests
{
    class PalavrasPrimasTest
    {
        [Test]
        public void RetornarValorLetraAminuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("a");
            Assert.AreEqual(1, retorno);
        }
        [Test]
        public void RetornarValorLetraXminuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("x");
            Assert.AreEqual(24, retorno);
        }
        [Test]
        public void RetornarValorLetraZminuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("z");
            Assert.AreEqual(26, retorno);
        }
        [Test]
        public void RetornarValorLetraAmaiuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("A");
            Assert.AreEqual(27, retorno);
        }
        [Test]
        public void RetornarValorLetraXmaiuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("X");
            Assert.AreEqual(50, retorno);
        }
        [Test]
        public void RetornarValorLetraZmaiuscula()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarValorLetra("Z");
            Assert.AreEqual(52, retorno);
        }
        [Test]
        public void RetornoSomaPalavra()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            var retorno = palavras.RetornarSomaPalavra("Daiana");
            Assert.AreEqual(56, retorno);
        }
        [Test]
        public void VerificaPalavraPrima()
        {
            PalavrasPrimas palavras = new PalavrasPrimas();
            bool retorno = palavras.VerificaPalavraPrima("naaa");
            Assert.AreEqual(true, retorno);
        }

    }
}
