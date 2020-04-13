using System.Collections.Generic;
using System.Linq;

namespace BotCovid.Core.Entidades
{
    public abstract class Pergunta
    {
        public int Ordem { get; private set; }
        public string Descricao { get; set; }
        public IList<Resposta> RespostasValidas { get; private set; }
        public int? IdResposta { get; set; }
        public Resposta Resposta
        {
            get
            {
                return RespostasValidas.FirstOrDefault(x => x.Id == IdResposta);
            }
        }
        public Pergunta(string descricao, int ordem, IList<Resposta> respostasValidas)
        {
            Ordem = ordem;
            Descricao = descricao;
            RespostasValidas = respostasValidas;
        }
        public abstract bool RealizarPergunta(IList<RespostaPergunta> respostasAnteriores);
        public abstract bool ValidarResposta(RespostaPergunta resposta);
    }
}