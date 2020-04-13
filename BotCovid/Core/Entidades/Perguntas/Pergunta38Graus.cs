using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades.Perguntas
{
    public class Pergunta38Graus : PerguntaTriagem
    {
        public Pergunta38Graus(string descricao, int ordem, IList<Resposta> respostasValidas) : base(descricao, ordem, respostasValidas)
        {
        }

        public override bool RealizarPergunta(IList<RespostaPergunta> respostasAnteriores)
        {
            return respostasAnteriores.Any(x => x.Pergunta is Pergunta37Graus && x.RespostaString == "1");
        }        
    }
}
