using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSatisfactionComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
