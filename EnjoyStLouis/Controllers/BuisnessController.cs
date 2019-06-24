using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnjoyStLouis.Data.Repositories;
using EnjoyStLouis.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EnjoyStLouis.Controllers
{
    public class BuisnessController : Controller
    {
        private Factory repositoryFactory;

        public BuisnessController(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        public IActionResult Index()
        {
            List<BuisnessListViewModel> buisnesses = BuisnessListViewModel.GetBuisness(repositoryFactory);
            return View(buisnesses);
        }
        [HttpGet]
        public IActionResult Create()
        {
            BuisnessCreateViewModel model = new BuisnessCreateViewModel(repositoryFactory);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(BuisnessCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            model.Persist(repositoryFactory);
            return RedirectToAction(actionName: nameof(Index));
        }
        
    }
}

    
