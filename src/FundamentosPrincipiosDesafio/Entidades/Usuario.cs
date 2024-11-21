using FundamentosPrincipiosDesafio.Enums;
using FundamentosPrincipiosDesafio.Interfaces;

namespace FundamentosPrincipiosDesafio.Entidades
{
    internal abstract class Usuario : IExecutorRequisicao
    {
        internal Usuario(string codigo, string nome, TipoUsuario tipoUsuario)
        {
            Codigo = codigo;
            Nome = nome;
            TipoUsuario = tipoUsuario;
        }

        public virtual int QuantidadeMaximaRequisicoes => 100;

        internal string Codigo { get; }
        internal string Nome { get; }
        internal TipoUsuario TipoUsuario { get; }
        internal int QuantidadeRequisicoes { get; private set; }

        internal void AdicionarRequisicao()
        {
            QuantidadeRequisicoes++;
        }

        internal static Usuario CriarUsuario(string codigo, string nome, TipoUsuario tipoUsuario)
        {
            switch (tipoUsuario)
            {
                case TipoUsuario.Basico:
                    return new UsuarioBasico(codigo, nome, tipoUsuario);
                case TipoUsuario.Completo:
                    return new UsuarioCompleto(codigo, nome, tipoUsuario);
                case TipoUsuario.Premium:
                    return new UsuarioPremium(codigo, nome, tipoUsuario);
                default:
                    throw new Exception("Tipo de usuário inválido");
            }
        }
    }
}
