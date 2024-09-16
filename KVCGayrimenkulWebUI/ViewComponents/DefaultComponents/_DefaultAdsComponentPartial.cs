using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultAdsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
