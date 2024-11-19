namespace FundamentosPrincipiosDesafio.Interfaces
{
    public interface IProcessarRequisicoes
    {
        List<RespostaRequisicoes> LerRequisicoes(string[] linhasArquivo);
    }
}
