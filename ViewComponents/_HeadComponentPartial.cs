﻿using Microsoft.AspNetCore.Mvc;

namespace BTK.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
               return View();   
        }
    }
}
