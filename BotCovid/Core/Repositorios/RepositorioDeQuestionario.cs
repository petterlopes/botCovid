using BotCovid.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Repositorios
{
    public class RepositorioDeQuestionario
    {
        private IList<Questionario> Questionarios { get; set; }
        public RepositorioDeQuestionario()
        {
            Questionarios = new List<Questionario>();
            InicializarQuestionarioPadrao();
        }
        private void InicializarQuestionarioPadrao()
        {
            var questionarioPadrao = new Questionario();
            questionarioPadrao.Perguntas.Add
        }
        public IEnumerable<Questionario> Buscar(Func<Questionario, bool> funcao)
        {
            return Questionarios.Where(funcao);
        }
    }
}
