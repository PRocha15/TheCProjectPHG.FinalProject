using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface IFillingRepository
    {
        IQueryable<Filling> Fillings { get; }

        Filling Insert(Filling filling);

        Filling Update(Filling filling);
        bool Delete(Guid identifier);
    }
}
