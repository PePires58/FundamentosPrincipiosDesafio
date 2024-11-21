using FundamentosPrincipiosDesafio.Entidades;
using FundamentosPrincipiosDesafio.Interfaces;
using FundamentosPrincipiosDesafio.ValueObjects;

namespace FundamentosPrincipiosDesafio.Servicos
{
    public class ProcessarRequisicoes : IProcessarRequisicoes
    {
        public List<RespostaRequisicoes> LerRequisicoes(string[] linhasArquivo)
        {
            if (linhasArquivo.Length == 0)            
                return [];
            
            List<LinhaArquivo> conteudoArquivo = [];
            foreach (var linha in linhasArquivo)
                conteudoArquivo.Add(
                    LinhaArquivo.CriarObjeto(linha)
                    );

            Requisicoes requisicoes = new();
            foreach (var linha in conteudoArquivo)
            {
                if (linha is LinhaArquivoUsuario linhaUsuario)
                    requisicoes.VincularUsuario(
                        Usuario.CriarUsuario(linhaUsuario.CodigoUsuario,
                            linhaUsuario.Nome,
                            linhaUsuario.TipoUsuario
                            )
                        );
                else if (linha is LinhaArquivoRequisicao linhaRequisicao)
                    requisicoes.AdicionarRequisicaoParaUsuario(
                        linhaRequisicao.CodigoUsuario);
            }

            List<RespostaRequisicoes> resposta = [];
            foreach (var item in requisicoes.Usuarios)
            {
                resposta.Add(new(item));
            }

            return resposta;
        }
    }
}
