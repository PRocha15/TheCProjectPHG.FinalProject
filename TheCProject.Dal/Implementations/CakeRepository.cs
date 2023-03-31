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
    public class CakeRepository: ICakeRepository
    {
        TheCProjectDbContext _dbContext;

        public CakeRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Cake> Cakes => _dbContext.Cake;

        public Cake Cake(Guid identifier)
        {
            Cake cake = _dbContext.Cake.Where(cake => cake.Identifier == identifier).First();
            return cake;
        }
        public bool Delete(Guid identifier)
        {
            Cake cake = Cake(identifier);
            _dbContext.Cake.Remove(cake);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Cake Insert(Cake cake)
        {
            _dbContext.Cake.Add(cake);
            int res = _dbContext.SaveChanges();
            return cake;
        }

        public Cake Update(Cake cake)
        {
            _dbContext.Cake.Update(cake);
            _dbContext.SaveChanges();

            return cake;
        }
    }
}
