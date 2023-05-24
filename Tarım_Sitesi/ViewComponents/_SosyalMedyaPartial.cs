using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _SosyalMedyaPartial : ViewComponent
    {
        private readonly ISosyalService _sosyalService;

        public _SosyalMedyaPartial(ISosyalService sosyalService)
        {
            _sosyalService = sosyalService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _sosyalService.GetListAll();
            return View(values);
        }
    }
}