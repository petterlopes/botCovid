using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades.Perguntas
{
    public class Pergunta37Graus: PerguntaTriagem
    {
        public Pergunta37Graus(string descricao, int ordem, IList<Resposta> respostasValidas) : base(descricao, ordem, respostasValidas)
        {
        }
    }
}
