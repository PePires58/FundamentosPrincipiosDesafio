namespace FundamentosPrincipiosDesafio.Entidades
{
    internal class Requisicoes
    {
        internal Requisicoes()
        {
            Usuarios = [];
        }

        internal List<Usuario> Usuarios { get; }

        internal void VincularUsuario(Usuario usuario)
        {
            if (Usuarios.Any(c => c.Codigo == usuario.Codigo))
            {
                var indice = Usuarios.FindIndex(c => c.Codigo == usuario.Codigo);
                Usuarios[indice] = usuario;
            }
            else
                Usuarios.Add(usuario);            
        }

        internal void AdicionarRequisicaoParaUsuario(string codigoUsuario)
        {
            Usuario usuario = Usuarios.First(c => c.Codigo == codigoUsuario);
            usuario.AdicionarRequisicao();
            VincularUsuario(usuario);
        }
    }
}
