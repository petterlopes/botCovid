using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpPost]
        public JsonResult EnviarMensagem([FromBody] ModelMensagem msg)
        {
            return new JsonResult(msg);
        }
        
    }
}