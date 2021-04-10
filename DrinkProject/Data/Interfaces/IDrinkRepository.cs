using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Models;

namespace DrinkProject.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int DrinkId); 
    }
}
