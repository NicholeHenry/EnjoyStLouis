using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnjoyStLouis.Data.Repositories;
using EnjoyStLouis.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnjoyStLouis.Controllers
{
    public class RateReviewController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int buisnessId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int buisnessId, RateReviewCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            model.Persist();
            return RedirectToAction(controllerName: nameof(Buisness), actionName: nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int id, RateReview rateReview)
        {
            return RedirectToAction(actionName: nameof(Index));
        }
        [HttpGet]
        public IActionResult Delete(int id, Factory repositoryFactory)
        {
            repositoryFactory.GetRateReviewRepository().Delete(id);
            return RedirectToAction(actionName: nameof(Index));
        }
        */
    }
}