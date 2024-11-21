using FundamentosPrincipiosDesafio.Enums;

namespace FundamentosPrincipiosDesafio.ValueObjects
{
    internal class LinhaArquivoUsuario : LinhaArquivo
    {
        internal LinhaArquivoUsuario(string conteudoLinha) : base(conteudoLinha) {
            CodigoUsuario = ConteudoLinha[1];
            Nome = ConteudoLinha[2];
            TipoUsuario = (TipoUsuario)Convert.ToInt32(ConteudoLinha[3]);
        }

        internal string CodigoUsuario { get; }
        internal string Nome { get; }
        internal TipoUsuario TipoUsuario { get; }
    }
}
