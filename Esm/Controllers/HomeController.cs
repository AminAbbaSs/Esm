using Microsoft.AspNetCore.Mvc;

namespace Esm.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
