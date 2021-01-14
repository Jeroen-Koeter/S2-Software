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
            return View(model);
        }
        public IActionResult AddDrankToBucketlist(int BucketlistID, int DrankID)
        {
            _bucketListRepository.AddDrank(BucketlistID, DrankID);
            return RedirectToAction("Index");
        }

        public IActionResult Show(BucketListViewModel model)
        {
            model.Drankjes = _bucketListRepository.GetDrankFromBucketlist(model.BucketListID);
            return View(model);
        }
    }
}
