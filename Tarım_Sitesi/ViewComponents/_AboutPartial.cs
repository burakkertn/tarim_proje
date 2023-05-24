﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _AboutPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _aboutService.GetListAll();

            return View(values);

        }
    }
}
