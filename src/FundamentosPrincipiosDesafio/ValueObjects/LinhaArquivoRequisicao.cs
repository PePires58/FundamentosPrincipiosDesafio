using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosPrincipiosDesafio.ValueObjects
{
    internal class LinhaArquivoRequisicao : LinhaArquivo
    {
        public LinhaArquivoRequisicao(string conteudoLinha) : base(conteudoLinha)
        {
            CodigoUsuario = ConteudoLinha[1];
        }

        internal string CodigoUsuario { get; }
    }
}
