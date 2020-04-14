using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades
{
    public class Usuario
    {
        public string Telefone { get; set; }
        public IList<RespostaPergunta> RespostasAnteriores { get; private set; }
        public Pergunta PerguntaAtual { get; set; }
        public Questionario QuestionarioAtual { get; set; }
        public Usuario(string telefone)
        {
            Telefone = telefone;
            RespostasAnteriores = new List<RespostaPergunta>();
        }
    }
}
