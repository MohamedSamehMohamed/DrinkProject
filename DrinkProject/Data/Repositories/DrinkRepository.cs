using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinkProject.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext db; 
        public DrinkRepository(AppDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Drink> Drinks => db.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => db.Drinks.Where(p => p.IsPreferred).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => db.Drinks.FirstOrDefault(p => p.Id == drinkId);
    }
}
