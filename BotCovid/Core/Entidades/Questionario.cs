using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Entidades
{
    public class Questionario
    {
        public IList<Pergunta> Perguntas { get; set; }
        public EnumeradorDeTiposDeQuestionario TipoQuestionario {get;set;}
        public Questionario(EnumeradorDeTiposDeQuestionario tipoQuestionario)
        {
            TipoQuestionario = tipoQuestionario;
            Perguntas = new List<Pergunta>();
        }
    }
}
