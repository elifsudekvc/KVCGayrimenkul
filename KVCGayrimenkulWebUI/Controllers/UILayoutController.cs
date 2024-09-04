using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
