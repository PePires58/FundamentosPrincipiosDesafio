using FundamentosPrincipiosDesafio.Interfaces;
using FundamentosPrincipiosDesafio.Servicos;

namespace FundamentosPrincipiosDesafio
{
    public class Program
    {
        public static IProcessarRequisicoes ProcessarRequisicoes { get; set; } = new ProcessarRequisicoes();

        public static void Main(string[] args) {

            ProcessarRequisicoes.LerRequisicoes(args);
        }
    }
}