using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BotCovid.Core.Bot;
using BotCovid.Core.Repositorios;
using BotCovid.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BotCovid.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        private RepositorioDeQuestionario repositorioQuestionario;
        private RepositorioDeUsuario repositorioUsuario;
        public HomeController()
        {
            repositorioQuestionario = new RepositorioDeQuestionario();
            repositorioUsuario = new RepositorioDeUsuario();
        }
        [HttpPost]
        public ActionResult EnviarMensagem([FromBody] ModelMensagem msg)
        {
            var usuario = repositorioUsuario.BuscarUsuarios(x => x.Telefone == msg.Usuario).FirstOrDefault();
            if (usuario == null)
            {
                usuario = new Core.Entidades.Usuario(msg.Usuario);
                usuario.QuestionarioAtual = repositorioQuestionario.Buscar(x => x.TipoQuestionario == Core.Entidades.EnumeradorDeTiposDeQuestionario.CadastroTriagem).FirstOrDefault();
                repositorioUsuario.AdicionarUsuario(usuario);
            }
            else
            {
                if (usuario.PerguntaAtual != null)
                {
                    var resposta = new Core.Entidades.RespostaPergunta(usuario.PerguntaAtual, msg.Mensagem);
                    if (!usuario.PerguntaAtual.ValidarResposta(resposta))
                    {
                        return Content($"<b>{msg.Usuario}</b>: {msg.Mensagem}\n\n" + "<b>BOT</b>: Resposta Inválida \n");
                    }
                    usuario.RespostasAnteriores.Add(resposta);
                }
                else
                {
                    usuario.QuestionarioAtual = repositorioQuestionario.Buscar(x => x.TipoQuestionario == Core.Entidades.EnumeradorDeTiposDeQuestionario.Monitoramento).FirstOrDefault();
                    usuario.RespostasAnteriores.Clear();
                }
            }
            var processoBot = new ProcessoBot();
            usuario.PerguntaAtual = processoBot.BuscaProximaPergunta(usuario.QuestionarioAtual, usuario.RespostasAnteriores, msg.Mensagem);
            var retornoBot = usuario.PerguntaAtual?.Descricao ?? "Obrigado por participar!";
            return Content($"<b>{msg.Usuario}</b>: {msg.Mensagem}\n\n" + @"<b>BOT</b>: " + retornoBot + "\n");
        }

    }
}