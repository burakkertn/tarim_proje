using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _HeadPartial: ViewComponent
    {
        public IViewComponentResult Invoke()

        {
            return View(); 

        }
    }
}
