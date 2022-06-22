using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDbContext : DbContext
    {
        public CategoryDbContext(DbContextOptions<CategoryDbContext> options)
        : base(options) { }

        public DbSet<Categoryy> categories { get; set; }
        public DbSet<SubCategory> subCategories { get; set; }


    }
}
