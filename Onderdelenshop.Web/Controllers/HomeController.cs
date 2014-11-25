using System.Web.Mvc;

namespace Onderdelenshop.Web.Controllers
{
    public class HomeController : OnderdelenshopControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}