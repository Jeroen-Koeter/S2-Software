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

        public BucketListController(IBucketListRepository bucketListRepository)
        {
            _bucketListRepository = bucketListRepository;
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
            _bucketListRepository.CreateBucketList(Naam,UserID);
            return RedirectToAction("Create");
        }

        public IActionResult AddDrank(int BucketListID) 
        {      
            return View(BucketListID);
        }
    }
}
