using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using Tarım_Sitesi.Models;

namespace Tarım_Sitesi.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.GetListAll();
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //[HttpGet]
        //public IActionResult AddContact()

        //{

        //    return View();
        //}
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //[HttpPost]
        //public IActionResult AddContact(Contact contact)
        //{
            
        //        _contactService.Insert(contact);
        //        return RedirectToAction("Index");

        //    }   //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            public IActionResult DeleteContact(int id)
        {
            var values = _contactService.GetById(id);
            _contactService.Delete(values);
            return RedirectToAction("Index");

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = _contactService.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateContact(Contact contact)
        {

            _contactService.Update(contact);


            return RedirectToAction("Index");



        }
    }
}