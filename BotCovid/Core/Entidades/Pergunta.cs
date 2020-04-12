using System.Collections.Generic;
using System.Linq;

namespace BotCovid.Core.Entidades
{
    public class Pergunta
    {
        public string Descricao { get; set; }
        public IList<Resposta> RespostasValidas { get; private set; }
        public int? IdResposta { get; set; }
        public Resposta Resposta {get
            {
                return RespostasValidas.FirstOrDefault(x => x.Id == IdResposta);
            }
        }
        public Pergunta(string descricao)
        {
            Descricao = descricao;
            RespostasValidas = new List<Resposta>();
        }
    }
}