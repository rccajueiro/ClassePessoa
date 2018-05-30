using System;
using ClassePessoa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassePessoaTest
{
    [TestClass]
    public class PessoaFisicaTest
    {
        [TestMethod]
        public void TestInstance()
        {
            int Codigo = 1;
            string Nome = "Ricardo Cajueiro";
            string Cpf = "999.999.999-99";

            PessoaFisica PessoaFisica = new PessoaFisica(Codigo, Nome, Cpf);

            Assert.AreEqual(Codigo, PessoaFisica.Codigo);
            Assert.AreEqual(Nome, PessoaFisica.Nome);
            Assert.AreEqual(Cpf, PessoaFisica.Cpf);
        }
    }
}
