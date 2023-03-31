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
    public class WeightRepository:IWeightRepository
    {
        TheCProjectDbContext _dbContext;

        public WeightRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Weight> Weights => _dbContext.Weight;

        public bool Delete(Guid identifier)
        {
            Weight Weight = _dbContext.Weight.Where(weight => weight.Identifier == identifier).First();
            _dbContext.Weight.Remove(Weight);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Weight Insert(Weight weight)
        {
            _dbContext.Weight.Add(weight);
            int res = _dbContext.SaveChanges();
            return weight;
        }

        public Weight Update(Weight weight)
        {
            _dbContext.Weight.Update(weight);
            _dbContext.SaveChanges();

            return weight;
        }
    }
}
