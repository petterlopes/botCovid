using BotCovid.Core.Entidades;
using BotCovid.Core.Entidades.Perguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotCovid.Core.Repositorios
{
    public class RepositorioDeQuestionario
    {
        private IList<Questionario> Questionarios { get; set; }
        private int ordem;
        public RepositorioDeQuestionario()
        {
            Questionarios = new List<Questionario>();
            InicializarQuestionarioPadrao();
        }
        private void InicializarQuestionarioPadrao()
        {
            ordem = 0;
            var questionarioPadrao = new Questionario(EnumeradorDeTiposDeQuestionario.CadastroTriagem);
            CarregarPerguntasTriagem(questionarioPadrao.Perguntas);
            CarregarPerguntasMonitoramento(questionarioPadrao.Perguntas);
            Questionarios.Add(questionarioPadrao);
            ordem = 0;
            var questionarioMonitoramento = new Questionario(EnumeradorDeTiposDeQuestionario.Monitoramento);
            CarregarPerguntasMonitoramento(questionarioMonitoramento.Perguntas);
            Questionarios.Add(questionarioMonitoramento);
        }

        private void CarregarPerguntasTriagem(IList<Pergunta> perguntas)
        {
            perguntas.Add(
                new PerguntaTriagem(@"Bem - vindo ao monitoramento do Covid da Brigada Militar de Caxias do Sul.
Diariamente você receberá perguntas, e é muito importante que você responda as mensagens diariamente para acompanhamento e monitoramento dos casos suspeitos de Covid - 19 na cidade.
As informações prestadas por meio deste canal serão de uso exclusivo da Brigada Militar e dos órgãos de saúde.
Em caso de dúvidas acesse o link ou ligue para 190.
Se concorda em participar, responda 1 para continuar. 😷👩‍🔬👨‍🔬", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Sim"),
                }));
            perguntas.Add(
                new PerguntaTriagem(@"Informe o seu Sexo: 
1 – Feminino
2 – Masculino
3 – Outros
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Feminino"),
                                        new Resposta(0, "2", "Masculino"),
                                        new Resposta(0, "3", "Outros"),
                }));
            perguntas.Add(
               new PerguntaTriagem(@"Informe sua faixa etária: 
1 - 0 – 20
2 - 21 – 30
3 - 31 – 40
4 - 41 – 50
5 – 51 - 60
6- 61 - 70
7 - 71 – 80
8 – Acima de 80
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "0 – 20"),
                                        new Resposta(0, "2", "21 – 30"),
                                        new Resposta(0, "3", "31 – 40"),
                                        new Resposta(0, "4", "41 – 50"),
                                        new Resposta(0, "5", "51 – 60"),
                                        new Resposta(0, "6", "61 – 70"),
                                        new Resposta(0, "7", "71 – 80"),
                                        new Resposta(0, "8", "Acima de 80"),
                }));
            perguntas.Add(
               new PerguntaTriagem(@"Informe se possui alguma doença crônica:
1 - Não possuo doenças crônicas
2 - Diabetes, hipertensão, asma
3 – Outras doenças crônicas
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Não possuo doenças crônicas"),
                                        new Resposta(0, "2", "Diabetes, hipertensão, asma"),
                                        new Resposta(0, "3", "Outras doenças crônicas"),
                }));
            perguntas.Add(
               new PerguntaTriagem(@"Você reside sozinho:
1 - Sim
2 - Não
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Sim"),
                                        new Resposta(0, "2", "Não"),
                }));
            perguntas.Add(
               new PerguntaTriagem(@"Para podermos mapear a sua região nos informe seu CEP.
Fique tranquilo, esta informação somente será utilizada para verificarmos o seu bairro e a UBS mais próxima da sua residência.
Caso não queira informar o seu CEP, responda esta mensagem com 0", ordem++, new List<Resposta>()
                {
                                        new RespostaCEP(0, "0", "CEP"),
                }));
        }

        private void CarregarPerguntasMonitoramento(IList<Pergunta> perguntas)
        {
            perguntas.Add(
                new Pergunta37Graus(@"Você teve febre acima de 37,5 graus em algum momento do dia: 
1 - Sim
2 - Não
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Sim"),
                                        new Resposta(0, "2", "Não"),
                }));
            perguntas.Add(
                new Pergunta38Graus(@"Teve febre acima de 38,5 graus em algum momento do dia?
1 – Sim
2 - Não
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Sim"),
                                        new Resposta(0, "2", "Não"),
                }));
            perguntas.Add(
                new PerguntaTriagem(@"Você teve falta de ar em algum momento do dia:
1 – Não tive falta de ar
2 – Falta de ar leve ou moderada
3 – Falta de ar grave
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Não tive falta de ar"),
                                        new Resposta(0, "2", "Falta de ar leve ou moderada"),
                                        new Resposta(0, "3", "Falta de ar grave"),
                }));
            perguntas.Add(
                new PerguntaTriagem(@"Você teve tosse em algum momento do dia:
1 – Não tive tosse
2 – Tosse leve ou moderada
3 – Tosse grave
📌 Responda apenas com um dos números acima. Exemplo 1", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Não tive tosse"),
                                        new Resposta(0, "2", "Tosse leve ou moderada"),
                                        new Resposta(0, "3", "Tosse grave"),
                }));
            perguntas.Add(
                new PerguntaTriagem(@"Como você se sente em relação ao dia de ontem:
1 – Sente-se melhor
2 – Sente-se igual
3 – Sente-se pior", ordem++, new List<Resposta>()
                {
                                        new Resposta(0, "1", "Sente-se melhor"),
                                        new Resposta(0, "2", "Sente-se igual"),
                                        new Resposta(0, "3", "Sente-se pior"),
                }));
            perguntas.Add(
               new PerguntaTriagem(@"Obrigado por responder o monitoramento diário. Para os próximos monitoramentos, em qual horário você prefere receber a mensagem:
1 - Manhã - 10h
2 – Tarde - 15h30
3 – Noite – 20h
📌 Responda apenas com um dos números acima. Exemplo 1 ", ordem++, new List<Resposta>()
               {
                                        new Resposta(0, "1", "Manhã - 10h"),
                                        new Resposta(0, "2", "Tarde - 15h30"),
                                        new Resposta(0, "3", "Noite – 20h"),
               }));
        }
        public IEnumerable<Questionario> Buscar(Func<Questionario, bool> funcao)
        {
            return Questionarios.Where(funcao);
        }
    }
}
