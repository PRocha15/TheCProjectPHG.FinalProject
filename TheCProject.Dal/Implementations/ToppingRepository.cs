using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Dal.Interfaces;
using TheCProject.Database.Context;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Implementations
{
    public class ToppingRepository:IToppingRepository
    {
        TheCProjectDbContext _dbContext;

        public ToppingRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Topping> Toppings => _dbContext.Topping;

        public bool Delete(Guid identifier)
        {
            Topping Topping = _dbContext.Topping.Where(topping => topping.Identifier == identifier).First();
            _dbContext.Topping.Remove(Topping);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Topping Insert(Topping topping)
        {
            _dbContext.Topping.Add(topping);
            int res = _dbContext.SaveChanges();
            return topping;
        }

        public Topping Update(Topping topping)
        {
            _dbContext.Topping.Update(topping);
            _dbContext.SaveChanges();

            return topping;
        }
    }
}
