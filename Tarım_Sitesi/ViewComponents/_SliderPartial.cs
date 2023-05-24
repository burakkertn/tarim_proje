using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _SliderPartial:ViewComponent
    {
     
        public IViewComponentResult Invoke()

        {
         
            return View();
        }

    }
}
