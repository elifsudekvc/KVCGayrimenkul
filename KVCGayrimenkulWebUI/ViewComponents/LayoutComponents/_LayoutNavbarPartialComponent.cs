﻿using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
