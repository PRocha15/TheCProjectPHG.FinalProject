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
    public class DecorationRepository: IDecorationRepository
    {
        TheCProjectDbContext _dbContext;

        public DecorationRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Decoration> Decorations => _dbContext.Decoration;

        public bool Delete(Guid identifier)
        {
            Decoration decoration = _dbContext.Decoration.Where(decoration => decoration.Identifier == identifier).First();
            _dbContext.Decoration.Remove(decoration);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Decoration Insert(Decoration decoration)
        {
            _dbContext.Decoration.Add(decoration);
            int res = _dbContext.SaveChanges();
            return decoration;
        }

        public Decoration Update(Decoration decoration)
        {
            _dbContext.Decoration.Update(decoration);
            _dbContext.SaveChanges();

            return decoration;
        }

    }

}
