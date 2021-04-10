using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkProject.Data.Models;

namespace DrinkProject.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
