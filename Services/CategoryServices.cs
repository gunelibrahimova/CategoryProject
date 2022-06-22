using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryServices
    {
        private readonly CategoryDbContext _categoryDbContext;

        public CategoryServices(CategoryDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext;
        }

        public void Create(Categoryy category)
        {
            _categoryDbContext.Add(category);
            _categoryDbContext.SaveChanges();
        }

        public List<Categoryy> GetAll()
        {
            return _categoryDbContext.categories.ToList();
        }
    }
}
