using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace Tarım_Sitesi.ViewComponents
{
    public class _TopAddress : ViewComponent
    {
        private readonly IAdressService _adressService;

        public _TopAddress(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IViewComponentResult Invoke()

        {
          var values =  _adressService.GetListAll();
            return View(values);
        }
    }
}