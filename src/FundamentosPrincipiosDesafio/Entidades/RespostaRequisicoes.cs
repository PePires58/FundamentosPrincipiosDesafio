using FundamentosPrincipiosDesafio.Interfaces;

namespace FundamentosPrincipiosDesafio.Entidades
{
    public class RespostaRequisicoes : ICalculadorRequisicoes
    {
        internal RespostaRequisicoes(Usuario usuario)
        {
            Usuario = usuario;

            ProcessarRequisicoes();
        }

        private Usuario Usuario { get; }
        public int Requisicoes => Usuario.QuantidadeRequisicoes;        
        public string Nome => Usuario.Nome;
        public int Sucesso { get; private set; }
        public int Erro { get; private set; }

        private void ProcessarRequisicoes()
        {
            Erro = CalcularQuantidadeRequisicoesErro();
            Sucesso = CalcularQuantidadeRequisicoesSucesso();
        }

        public int CalcularQuantidadeRequisicoesSucesso()
        {
            int quantidadeMaximaRequisicoes = Usuario.QuantidadeMaximaRequisicoes;
            int quantidadeRequisicoes = Usuario.QuantidadeRequisicoes;
            if (quantidadeRequisicoes > quantidadeMaximaRequisicoes)
                return quantidadeMaximaRequisicoes;
            return quantidadeRequisicoes;
        }

        public int CalcularQuantidadeRequisicoesErro()
        {
            int quantidadeMaximaRequisicoes = Usuario.QuantidadeMaximaRequisicoes;
            int quantidadeRequisicoes = Usuario.QuantidadeRequisicoes;

            if (quantidadeRequisicoes > quantidadeMaximaRequisicoes)
                return quantidadeRequisicoes - quantidadeMaximaRequisicoes;
            return 0;
        }
    }
}
