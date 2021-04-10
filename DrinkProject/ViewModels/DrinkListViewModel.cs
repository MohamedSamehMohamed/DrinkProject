using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Models;

namespace DrinkProject.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory  { get; set; }
    }
}
