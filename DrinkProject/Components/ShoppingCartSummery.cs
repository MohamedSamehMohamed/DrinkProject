using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Models;
using DrinkProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkProject.Components
{
    public class ShoppingCartSummery: ViewComponent
    {
        private readonly ShoppingCart shoppingCart;
        public ShoppingCartSummery(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart; 
        }
        public IViewComponentResult Invoke()
        {
 //           var items = shoppingCart.GetShoppingCartItems();
            var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem(), new ShoppingCartItem(), new ShoppingCartItem() };
            shoppingCart.ShoppingCartItems = items;
            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartVM);
        }
    }
}
