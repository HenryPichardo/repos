using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SED.Models;

namespace SED.Controllers
{
    public class EvaluadorController : Controller
    {
        // GET: Evaluador
        public ActionResult Index()
        {
            var Evaluador = new EvaluadorBLL();
            return View(Evaluador.GetListaEvaluadores());
        }

        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }
    }
}