using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades.Perguntas
{
    public class PerguntaTriagem : Pergunta
    {
        public PerguntaTriagem(string descricao, int ordem, IList<Resposta> respostasValidas):base(descricao, ordem, respostasValidas)
        {
        }

        public override bool RealizarPergunta(IList<RespostaPergunta> respostasAnteriores)
        {
            return true;
        }

        public override bool ValidarResposta(RespostaPergunta resposta)
        {
            return RespostasValidas.Any(x=>x.ValidarValor(resposta.RespostaString));
        }
    }
}
