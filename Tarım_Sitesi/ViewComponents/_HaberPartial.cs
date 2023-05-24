using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _HaberPartial: ViewComponent
    {
        private readonly IHaberService _haberService;

        public _HaberPartial(IHaberService haberService)
        {
            _haberService = haberService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _haberService.GetListAll();
            return View(values);


        }
    }
}
