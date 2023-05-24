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
    public class ResimController : Controller
    {
        private readonly IResimService _resimService;

        public ResimController(IResimService resimService)
        {
            _resimService = resimService;
        }

        public IActionResult Index()
        {
            var values = _resimService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddResim()

        {

            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AddResim(Resim resim)
        {
            ImageVali validationRules = new ImageVali();
            ValidationResult result = validationRules.Validate(resim);
            if (result.IsValid)
            {
                _resimService.Insert(resim);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public IActionResult DeleteResim(int id)
        {
            var values = _resimService.GetById(id);
            _resimService.Delete(values);
            return RedirectToAction("Index");

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult UpdateResim(int id)
        {
            var values = _resimService.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateResim(Resim resim)
        {


            _resimService.Update(resim);

            return RedirectToAction("Index");



        }
    }
}
