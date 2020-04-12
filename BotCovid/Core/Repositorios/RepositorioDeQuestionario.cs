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
            var questionarioPadrao = new Questionario(EnumeradorDeTiposDeQuestionario.CadastroInicial);
            var pergunta = new Pergunta(@"Bem-vindo ao monitoramento do Covid da Brigada Militar de Caxias do Sul.  
Diariamente você receberá perguntas, e é muito importante que você responda as mensagens diariamente para acompanhamento e monitoramento dos casos suspeitos de Covid - 19 na cidade.
As informações prestadas por meio deste canal serão de uso exclusivo da Brigada Militar e dos órgãos de saúde.
Em caso de dúvidas acesse o link ou ligue para 190.
Se concorda em participar, responda 1 para continuar. 😷👩‍🔬👨‍🔬");
            pergunta.RespostasValidas.Add(new Resposta(0, "1", "Sim"));
            questionarioPadrao.Perguntas.Add(pergunta);
        }
        public IEnumerable<Questionario> Buscar(Func<Questionario, bool> funcao)
        {
            return Questionarios.Where(funcao);
        }
    }
}
