using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
