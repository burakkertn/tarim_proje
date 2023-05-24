using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _MapPartail: ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            TarımContext tarımContext = new TarımContext();
            var values = tarımContext.Adresler.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.v = values;
            return View();
        }
    }
}
