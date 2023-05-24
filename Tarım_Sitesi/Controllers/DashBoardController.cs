using Microsoft.AspNetCore.Mvc;

namespace Tarım_Sitesi.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
