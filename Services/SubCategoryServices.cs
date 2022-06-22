using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubCategoryServices
    {
        private readonly CategoryDbContext _categoryDbContext;

        public SubCategoryServices(CategoryDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
        }

        public List<SubCategory> GetAll()
        {
            var subCategories = _categoryDbContext.subCategories.Include(x=>x.Category).ToList();
               return subCategories;
        }

        public void Create(SubCategory subcategory)
        {
            _categoryDbContext.Add(subcategory);
            _categoryDbContext.SaveChanges();
        }


    }
}
