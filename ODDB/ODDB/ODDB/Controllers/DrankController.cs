using System;
using System.Dynamic;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Repository.Repositories;
using ODDB.Common.Entities;

namespace ODDB.Controllers
{
    public class DrankController : Controller
    {
        private readonly IDrankRepository _drankRepository;

        public DrankController(IDrankRepository drankRepository) 
        {
            _drankRepository = drankRepository;
        }

        public IActionResult Index() 
        {
            dynamic model = new ExpandoObject();
            model.Drank = _drankRepository.GetAll();
            return View(model);
        }

        public IActionResult AddDrank()
        {
            return View();
        }

        public IActionResult ZoekDrank() 
        {
            return View();
        }

        public IActionResult CreateDrank(Drank drank) 
        {
            var Nieuwdrank = new Drank()
            {
                Naam = drank.Naam,
                Type = drank.Type,
                Omschrijving = drank.Omschrijving,
                AlcoholPecentage=drank.AlcoholPecentage                
            };
            _drankRepository.CreateDrank(Nieuwdrank);
            return RedirectToAction("Index");
        }

        public IActionResult GetDrankByAttribute(string Attribute, string data)
        {
            dynamic model = new ExpandoObject();
            model.Drank = _drankRepository.GetDrankByAttribute(Attribute, data);
            return View("Result",model);
        }

        public IActionResult Delete(int DrankID)
        {
            _drankRepository.DeleteDrank(DrankID);
            return RedirectToAction("Index");
        }
        public IActionResult Update(int DrankID) 
        {
            return View("update", DrankID);
        }

      //  public IActionResult UpdateDrank(Drank drank) 
        //{
        //    return;
        //}
    }
}
