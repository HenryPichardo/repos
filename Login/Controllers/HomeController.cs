using System.Web.Mvc;
using Login.Models;

namespace AutenticacionPersonalizada.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        BiblionetEntities db = new BiblionetEntities();

        // GET: Home
        public ActionResult Index()
        {
            var datos = db.Libro;
            return View(datos);
        }
    }
}