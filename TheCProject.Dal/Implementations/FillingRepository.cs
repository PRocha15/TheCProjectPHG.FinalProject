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
    public class FillingRepository: IFillingRepository
    {
        TheCProjectDbContext _dbContext;

        public FillingRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Filling> Fillings => _dbContext.Filling;

        public bool Delete(Guid identifier)
        {
            Filling filling = _dbContext.Filling.Where(filling => filling.Identifier == identifier).First();
            _dbContext.Filling.Remove(filling);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Filling Insert(Filling filling)
        {
            _dbContext.Filling.Add(filling);
            int res = _dbContext.SaveChanges();
            return filling;
        }

        public Filling Update(Filling filling)
        {
            _dbContext.Filling.Update(filling);
            _dbContext.SaveChanges();

            return filling;
        }
    }
}
