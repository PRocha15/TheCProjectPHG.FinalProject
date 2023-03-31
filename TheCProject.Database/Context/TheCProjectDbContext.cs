using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Database.Context
{
    public class TheCProjectDbContext:DbContext
    {
        public TheCProjectDbContext(DbContextOptions<TheCProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Cake> Cake { get; set; }

        public DbSet<Decoration> Decoration { get; set; }
        public DbSet<Filling> Filling { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<Weight> Weight { get; set; }
        public DbSet<Topping> Topping { get; set; }

    }
}
