using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrinkProject.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository CategoryRepository;
        private readonly IDrinkRepository DrinkRepository;
        public DrinkController(ICategoryRepository CategoryRepository, IDrinkRepository DrinkRepository)
        {
            this.CategoryRepository = CategoryRepository;
            this.DrinkRepository = DrinkRepository;
        }
        // GET: DrinkController
        public ActionResult Index()
        {
            var drinks = DrinkRepository.Drinks;
            DrinkListViewModel model = new()
            {
                Drinks = drinks,
                CurrentCategory = "Current category"
            };
            return View(model);
        }

        // GET: DrinkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DrinkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrinkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrinkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrinkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrinkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrinkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
