using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.Data.Models;

namespace DrinkProject.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext db;
        public CategoryRepository(AppDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Category> Categories => throw new NotImplementedException();
    }
}
