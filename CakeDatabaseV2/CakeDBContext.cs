using CakeDatabase.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace CakeDatabase
{
    public class CakeDBContext  : DbContext
    {
        public CakeDBContext(DbContextOptions<CakeDBContext> options) : base(options)
        {

        }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Cake> Cakes { get; set; }

    }
}
