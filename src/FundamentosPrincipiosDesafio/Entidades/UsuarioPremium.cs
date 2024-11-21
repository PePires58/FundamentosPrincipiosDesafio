using FundamentosPrincipiosDesafio.Enums;

namespace FundamentosPrincipiosDesafio.Entidades
{
    internal class UsuarioPremium : Usuario
    {
        internal UsuarioPremium(string codigo, string nome, TipoUsuario tipoUsuario) : base(codigo, nome, tipoUsuario)
        {
        }

        public override int QuantidadeMaximaRequisicoes => 20_000;
    }
}
