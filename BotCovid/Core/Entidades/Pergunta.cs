using System.Collections.Generic;

namespace BotCovid.Core.Entidades
{
    public class Pergunta
    {
        public IList<Resposta> RespostasValidas { get; set; }
    }
}