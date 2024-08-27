using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
