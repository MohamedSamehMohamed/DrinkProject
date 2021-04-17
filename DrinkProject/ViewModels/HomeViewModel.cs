using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Models;

namespace DrinkProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> preferredDrinks { get; set; }
    }
}
