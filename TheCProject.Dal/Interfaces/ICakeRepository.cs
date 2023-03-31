using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface ICakeRepository
    {
        IQueryable<Cake> Cakes { get; }

        Cake Insert(Cake cake);
        public Cake Cake(Guid identifier);

        Cake Update(Cake cake);
        bool Delete(Guid identifier);
    }
}
