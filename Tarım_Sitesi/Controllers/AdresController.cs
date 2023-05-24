using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValiRuler;
using EntityLayer.Entities;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using Tarım_Sitesi.Models;


namespace Tarım_Sitesi.Controllers
{
    public class AdresController : Controller
    {
        private readonly IAdressService _adressService;

        public AdresController(IAdressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult Index()
        {
            var values = _adressService.GetListAll();
            return View(values);
        }
       
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     
        [HttpGet]
        public IActionResult UpdateAdres(int id)
        {
            var values = _adressService.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateAdres(Adres adres)
        {


            _adressService.Update(adres);

            return RedirectToAction("Index");



        }
    }
}
