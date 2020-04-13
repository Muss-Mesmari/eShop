using eShop.infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
