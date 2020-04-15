using eShop.Data.Data;
using eShop.Data.IRepository;
using eShop.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace eShop.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly eShopDbContext _eShopDbContext;

        public CategoryRepository(eShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _eShopDbContext.Categories;

        public List<SelectListItem> PopulateCategories()
        {
            List<SelectListItem> Categories = new List<SelectListItem>();
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                string query = " SELECT CategoryName, CategoryId FROM Categories";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            Categories.Add(new SelectListItem
                            {
                                Text = sdr["CategoryName"].ToString(),
                                Value = sdr["CategoryId"].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            return Categories;
        }
    }
}
