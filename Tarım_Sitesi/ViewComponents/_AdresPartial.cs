using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _AdresPartial : ViewComponent
    {
        private readonly IAdressService _adressService;

        public _AdresPartial(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _adressService.GetListAll();

            return View(values);
        }
    }
}