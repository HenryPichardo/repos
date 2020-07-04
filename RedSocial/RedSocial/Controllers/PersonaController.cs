using RedSocial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedSocial.Controllers
{
    public class PersonaController : Controller
    {
        RED_SOCIALEntities db = new RED_SOCIALEntities();
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult autenticar(PERSONA p)
        {
            PERSONA person = db.AUTENTICAR(p.CORREO, p.CONTRASENIA).FirstOrDefault();
            if (person != null)
            {
                Session["user"] = person;
                return RedirectToAction("Index","Principal");
            }
            else
            {
                return View("Login");
            }
           
        }
    }
}