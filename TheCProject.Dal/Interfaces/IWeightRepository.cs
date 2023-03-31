using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface IWeightRepository
    {
        IQueryable<Weight> Weights { get; }

        Weight Insert(Weight weight);

        Weight Update(Weight weight);
        bool Delete(Guid identifier);
    }
}
