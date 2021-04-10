using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Interfaces;
using DrinkProject.Data.Models;

namespace DrinkProject.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{Name="Hot", Description="This is a hot Drink"},
                    new Category{Name="Cold", Description="This is a cold Drink"}
                };
            }
        }
    }
}
