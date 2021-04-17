using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.Data.Models;
using DrinkProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository drinkReposotory;
        private readonly ShoppingCart shoppingCart;
        public ShoppingCartController(IDrinkRepository drinkReposotory, ShoppingCart shoppingCart)
        {
            this.drinkReposotory = drinkReposotory;
            this.shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;
            var ShoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };
            return View(ShoppingCartVM);
        }
        public RedirectToActionResult AddToShoppingCart(int DrinkId)
        {
            var SelectedDrink = drinkReposotory.Drinks.FirstOrDefault(p => p.Id == DrinkId); 
            if (SelectedDrink != null)
            {
                shoppingCart.AddToCart(SelectedDrink, 1);
            }
            return RedirectToAction("Index"); 
        }
        public RedirectToActionResult RemoveFromShoppingCart(int DrinkId)
        {
            var SelectedDrink = drinkReposotory.Drinks.FirstOrDefault(p => p.Id == DrinkId);
            if (SelectedDrink != null)
            {
                shoppingCart.RemoveFromCart(SelectedDrink);
            }
            return RedirectToAction("Index");
        }
    }
}
