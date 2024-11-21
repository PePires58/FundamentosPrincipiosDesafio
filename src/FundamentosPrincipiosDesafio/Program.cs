using FundamentosPrincipiosDesafio.Interfaces;
using FundamentosPrincipiosDesafio.Servicos;

namespace FundamentosPrincipiosDesafio
{
    public class Program
    {
        public static IProcessarRequisicoes ProcessarRequisicoes { get; set; } = new ProcessarRequisicoes();

        public static void Main(string[] args) {

            /*
             * Descomente para testar em modo debug
             * 
             
                args = ["01;AASSBC-2341BCS-213;PEDRO PIRES;3",
                    "02;AASSBC-2341BCS-213;;"];
             
             */

            ProcessarRequisicoes.LerRequisicoes(args);
        }
    }
}