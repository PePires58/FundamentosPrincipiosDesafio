using FundamentosPrincipiosDesafio.Enums;

namespace FundamentosPrincipiosDesafio.Entidades
{
    internal class UsuarioCompleto : Usuario
    {
        internal UsuarioCompleto(string codigo, string nome, TipoUsuario tipoUsuario) : base(codigo, nome, tipoUsuario)
        {
        }

        public override int QuantidadeMaximaRequisicoes => 1_000;
    }
}
