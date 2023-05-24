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

    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values = _teamService.GetListAll();
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult AddTeam()

        {

            return View();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            TeamVali validationRules = new TeamVali();
            ValidationResult result = validationRules.Validate(team);
            if (result.IsValid)
            {
                _teamService.Insert(team);
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
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.GetById(id);
            _teamService.Delete(values);
            return RedirectToAction("Index");

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var values = _teamService.GetById(id);
            return View(values);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        [HttpPost]

        public IActionResult UpdateTeam(Team team)
        {


            _teamService.Update(team);

            return RedirectToAction("Index");



        }
    }

}