namespace FundamentosPrincipiosDesafio.ValueObjects
{
    internal abstract class LinhaArquivo
    {
        internal LinhaArquivo(string conteudoLinha)
        {
            Separador = ';';
            ConteudoLinha = conteudoLinha.Split(Separador);
        }

        protected internal virtual char Separador { get; }
        protected internal string[] ConteudoLinha { get; }

        internal static LinhaArquivo CriarObjeto(string conteudoLinha)
        {
            if(conteudoLinha.Substring(0,2) == "01")
                return new LinhaArquivoUsuario(conteudoLinha);
            return new LinhaArquivoRequisicao(conteudoLinha);
        }
    }
}
