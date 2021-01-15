using Microsoft.AspNetCore.Mvc;
using System;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;
using ODDB.Models;

namespace ODDB.Controllers
{
    public class BucketListController : Controller
    {
        private readonly IBucketListRepository _bucketListRepository;
        private readonly IDrankRepository _drankRepository;

        public BucketListController(IBucketListRepository bucketListRepository, IDrankRepository drankRepository)
        {
            _bucketListRepository = bucketListRepository;
            _drankRepository = drankRepository;
        }
        public IActionResult Index(string UserID)
        {
            dynamic model = new ExpandoObject();
            model.Bucketlist = _bucketListRepository.GetBucketlistsByUser(UserID);
            if (model.Bucketlist == null) 
            {
                return LocalRedirect("/Home/error");
            }
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }
        public IActionResult CreateBucketList(string Naam, string UserID)
        {
            _bucketListRepository.CreateBucketList(Naam, UserID);
            return RedirectToAction("Create");
        }

        public IActionResult AddDrank(BucketListViewModel model)
        {

            model.Drankjes = _bucketListRepository.GetNotInBucketlist(model.BucketListID);
            if (model.Drankjes == null)
            {
                return LocalRedirect("/Home/error");
            }
            return View(model);
        }
        public IActionResult AddDrankToBucketlist(int BucketlistID, int DrankID)
        {
            _bucketListRepository.AddDrank(BucketlistID, DrankID);
            BucketListViewModel model = new BucketListViewModel();
            model.BucketListID = BucketlistID;
            return RedirectToAction("AddDrank", model);
        }

        public IActionResult Show(BucketListViewModel model)
        {
            model.Drankjes = _bucketListRepository.GetDrankFromBucketlist(model.BucketListID);
            if (model.Drankjes == null)
            {
                return LocalRedirect("/Home/error");
            }
            return View(model);
        }
        public IActionResult Delete(BucketListViewModel model, Guid UserID) 
        {
            
            _bucketListRepository.Deletebucketlist(model.BucketListID);
            _bucketListRepository.Deletebucketlistentry(model.BucketListID);
            return LocalRedirect("/Home/Index");
        }
    }
}
