using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public HomeController()
        {
            repositorioQuestionario = new RepositorioDeQuestionario();
        }
        [HttpPost]
        public ActionResult EnviarMensagem([FromBody] ModelMensagem msg)
        {
            var questionarios = repositorioQuestionario.Buscar(x => x.TipoQuestionario == Core.Entidades.EnumeradorDeTiposDeQuestionario.CadastroTriagem);
            return Content($"<b>{msg.Usuario}</b>: {msg.Mensagem}\n\n"+ @"<b>BOT</b>: Bem - vindo ao monitoramento do Covid da Brigada Militar de Caxias do Sul.
Diariamente você receberá perguntas, e é muito importante que você responda as mensagens diariamente para acompanhamento e monitoramento dos casos suspeitos de Covid - 19 na cidade.
As informações prestadas por meio deste canal serão de uso exclusivo da Brigada Militar e dos órgãos de saúde.
Em caso de dúvidas acesse o link ou ligue para 190.
Se concorda em participar, responda 1 para continuar. 😷👩‍🔬👨‍🔬" + "\n");
        }
        
    }
}