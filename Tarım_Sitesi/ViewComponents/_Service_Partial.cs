using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.ViewComponents
{
    public class _Service_Partial: ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _Service_Partial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()

        {
            var values = _serviceService.GetListAll();
            return View(values);  
        
        
        }



    }
}
