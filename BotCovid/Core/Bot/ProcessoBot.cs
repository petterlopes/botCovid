using BotCovid.Core.Entidades;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Bot
{
    public class ProcessoBot
    {
        public Pergunta BuscaProximaPergunta(Questionario questionario, IList<RespostaPergunta> respostasAnteriores, string respostaAtual)
        {
            foreach(var pergunta in questionario.Perguntas.Where(x => !respostasAnteriores.Any(y => y.Pergunta.Descricao == x.Descricao)).OrderBy(x=>x.Ordem))
            {
                if (pergunta.RealizarPergunta(respostasAnteriores))
                {
                    return pergunta;
                }
            }
            return null;
        }
    }
}
