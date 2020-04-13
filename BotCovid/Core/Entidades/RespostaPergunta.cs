using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades
{
    public class RespostaPergunta
    {
        public Pergunta Pergunta { get; set; }
        public Resposta Resposta { get; set; }
        public string RespostaString { get; set; }

        public RespostaPergunta(Pergunta pergunta, Resposta resposta, string respostaString)
        {
            Pergunta = pergunta;
            Resposta = resposta;
            RespostaString = respostaString;
        }
    }
}

