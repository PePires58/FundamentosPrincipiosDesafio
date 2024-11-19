using FundamentosPrincipiosDesafio.Interfaces;
using FundamentosPrincipiosDesafio.Servicos;
using System.Text;

namespace FundamentosPrincipiosDesafio.Tests
{
    [TestClass]
    public class ProcessarRequisicoesTests
    {
        IProcessarRequisicoes ProcessarRequisicoes { get; }

        public ProcessarRequisicoesTests()
        {
            ProcessarRequisicoes = new ProcessarRequisicoes();
        }

        [TestMethod]
        public void DeveRetornarVazioQuandoNaoReceberNada()
        {
            var resposta = ProcessarRequisicoes.LerRequisicoes([]);

            Assert.IsNotNull(resposta);
            Assert.AreEqual(0, resposta.Count);
        }

        [TestMethod]
        public void DeveRetornarListaComUmItemEZeroRequisicoes()
        {
            var arquivo = "01;AASSBC-2341BCS-213;PEDRO PIRES;1";

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo]);
            var primeiroItem = resposta.First();

            Assert.AreEqual(1, resposta.Count);
            Assert.AreEqual("PEDRO PIRES", primeiroItem.Nome);
            Assert.AreEqual(0, primeiroItem.Requisicoes);
            Assert.AreEqual(0, primeiroItem.Sucesso);
            Assert.AreEqual(0, primeiroItem.Erro);
        }

        [TestMethod]
        public void DeveRetornarListaComUmItemEUmaRequisicao()
        {
            StringBuilder arquivo = new();
            arquivo.AppendLine("01;AASSBC-2341BCS-213;PEDRO PIRES;1");
            arquivo.AppendLine("02;AASSBC-2341BCS-213;;");
            

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo.ToString()]);
            var primeiroItem = resposta.First();

            Assert.AreEqual(1, resposta.Count);
            Assert.AreEqual("PEDRO PIRES", primeiroItem.Nome);
            Assert.AreEqual(1, primeiroItem.Requisicoes);
            Assert.AreEqual(1, primeiroItem.Sucesso);
            Assert.AreEqual(0, primeiroItem.Erro);
        }

        [TestMethod]
        public void DeveRetornarListaComMaisDeUmUsuario()
        {
            StringBuilder arquivo = new();
            arquivo.AppendLine("01;AASSBC-2341BCS-213;PEDRO PIRES;1");
            arquivo.AppendLine("01;AASSBC-23412XS-000;JAELSON LIMA;2");
            arquivo.AppendLine("02;AASSBC-2341BCS-213;;");

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo.ToString()]);

            Assert.AreEqual(2, resposta.Count);
        }

        [TestMethod]
        public void DeveRetornarUmaRequisicaoPorErro()
        {
            StringBuilder arquivo = new();
            arquivo.AppendLine("01;AASSBC-2341BCS-213;PEDRO PIRES;1");

            for (int i = 0; i < 102; i++)
                arquivo.AppendLine("02;AASSBC-2341BCS-213;;");

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo.ToString()]);

            Assert.AreEqual(1, resposta.Count);
            Assert.AreEqual(101, primeiroItem.Requisicoes);
            Assert.AreEqual(100, primeiroItem.Sucesso);
            Assert.AreEqual(1, primeiroItem.Erro);
        }

        [TestMethod]
        public void DeveRetornarUmaRequisicaoPorErroPerfilCompleto()
        {
            StringBuilder arquivo = new();
            arquivo.AppendLine("01;AASSBC-2341BCS-213;PEDRO PIRES;1");

            for (int i = 0; i < 10002; i++)
                arquivo.AppendLine("02;AASSBC-2341BCS-213;;");

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo.ToString()]);

            Assert.AreEqual(1, resposta.Count);
            Assert.AreEqual(1001, primeiroItem.Requisicoes);
            Assert.AreEqual(1000, primeiroItem.Sucesso);
            Assert.AreEqual(1, primeiroItem.Erro);
        }

        [TestMethod]
        public void DeveRetornarUmaRequisicaoPorErroPerfilPremium()
        {
            StringBuilder arquivo = new();
            arquivo.AppendLine("01;AASSBC-2341BCS-213;PEDRO PIRES;1");

            for (int i = 0; i < 20002; i++)
                arquivo.AppendLine("02;AASSBC-2341BCS-213;;");

            var resposta = ProcessarRequisicoes.LerRequisicoes([arquivo.ToString()]);

            Assert.AreEqual(1, resposta.Count);
            Assert.AreEqual(20001, primeiroItem.Requisicoes);
            Assert.AreEqual(20000, primeiroItem.Sucesso);
            Assert.AreEqual(1, primeiroItem.Erro);
        }
    }
}
