using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
