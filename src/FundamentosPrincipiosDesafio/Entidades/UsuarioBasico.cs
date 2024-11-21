using FundamentosPrincipiosDesafio.Enums;

namespace FundamentosPrincipiosDesafio.Entidades
{
    internal class UsuarioBasico : Usuario
    {
        internal UsuarioBasico(string codigo, string nome, TipoUsuario tipoUsuario) : base(codigo, nome, tipoUsuario)
        {
        }
    }
}
