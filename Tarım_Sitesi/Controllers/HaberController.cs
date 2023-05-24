using BusinessLayer.Abstract;
using BusinessLayer.ValiRuler;
using EntityLayer.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Tarım_Sitesi.Models;

namespace Tarım_Sitesi.Controllers
{
    public class HaberController : Controller
    {
        private readonly IHaberService _haberService;

        public HaberController(IHaberService haberService)
        {
            _haberService = haberService;
        }

        public IActionResult Index()
        {
            var values = _haberService.GetListAll();
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult AddHaber()

        {

            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AddHaber(Haberler haberler)
        {
            haberler.Tarih= DateTime.Parse(DateTime.Now.ToShortDateString());
            haberler.Status = false;
           _haberService.Insert(haberler);
            return RedirectToAction("Index");
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        public IActionResult DeleteHaber(int id)
        {
            var values = _haberService.GetById(id);
            _haberService.Delete(values);
            return RedirectToAction("Index");

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult UpdateHaber(int id)
        {
            var values = _haberService.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateHaber(Haberler haberler)
        {

            _haberService.Update(haberler);


            return RedirectToAction("Index");



        }
        public IActionResult ChangeStatusToTrue(int id)
        {

            _haberService.HaberlerStatusToTrue(id);
            return RedirectToAction("Index");



        }
        public IActionResult ChangeStatusToFalse(int id)
        {

            _haberService.HaberlerStatusToFalse(id);
            return RedirectToAction("Index");



        }
    }
}
