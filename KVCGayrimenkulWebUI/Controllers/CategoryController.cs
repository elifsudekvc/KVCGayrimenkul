using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
