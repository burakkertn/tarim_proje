using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _GaleriPartial : ViewComponent
    {
        private readonly IResimService _resimService;

        public _GaleriPartial(IResimService resimService)
        {
            _resimService = resimService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _resimService.GetListAll();
           
            return View(values);


        }
    }
}
