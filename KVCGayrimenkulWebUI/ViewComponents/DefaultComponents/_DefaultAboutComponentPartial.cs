﻿using Microsoft.AspNetCore.Mvc;

namespace KVCGayrimenkulWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultAboutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
