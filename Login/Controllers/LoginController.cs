using System.Web.Mvc;
using System.Web.Security;
using Login.Models;

namespace AutenticacionPersonalizada.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario model)
        {
            if (Membership.ValidateUser(model.Login, model.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(model.Login, false);
                return null;
            }
            return View(model);
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}