using Conexion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Conexion.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            RegistroLibro rp = new RegistroLibro();
            return View(rp.RecuperarTodos());
        }
        public ActionResult Grabar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Grabar(FormCollection collection)
        {
            RegistroLibro rp = new RegistroLibro();
            Libro lib = new Libro
            {
                //Codigo = int.Parse(collection["Codigo"]),
                Titulo = collection["Titulo"],
                Autor = collection["Autor"],
                ISBN = collection["ISBN"],
                Editora = collection["Editora"],
                URL = collection["URL"]
               
            };
            rp.GrabarLibro(lib);
            return RedirectToAction("Index");
        }
        public ActionResult Borrar(int cod)
        {
            RegistroLibro lib = new RegistroLibro();
            lib.Borrar(cod);
            return RedirectToAction("Index");
        }
        public ActionResult Modificacion(int cod)
        {
            RegistroLibro lib = new RegistroLibro();
            Libro rpt = lib.Recuperar(cod);
            return View(rpt);
        }
        [HttpPost]
        public ActionResult Modificacion(FormCollection collection)
        {
            RegistroLibro lib = new RegistroLibro();
            Libro rpt = new Libro
            {
                //Codigo = int.Parse(collection["Codigo"]),
                Titulo = collection["Titulo"],
                Autor = collection["Autor"],
                ISBN = collection["ISBN"],
                Editora = collection["Editora"],
                URL = collection["URL"]
               
            };
            lib.Modificar(rpt);
            return RedirectToAction("Index");
        }



    }
}