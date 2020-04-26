using eShop.Entities.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;


namespace eShop.Infrastructure.Services
{
    public interface ICategoryService
    {
        IEnumerable<Category> AllCategories { get; }
      
    }
}
