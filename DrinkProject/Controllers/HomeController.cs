using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository drinkRepository;
        public HomeController(IDrinkRepository drinkRepository)
        {
            this.drinkRepository = drinkRepository;
        }
        public IActionResult Index()
        {
            var HomeVM = new HomeViewModel { preferredDrinks = drinkRepository.PreferredDrinks };
            return View(HomeVM);
        }
    }
}
