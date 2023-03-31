using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface IToppingRepository
    {
        IQueryable<Topping> Toppings { get; }

        Topping Insert(Topping topping);

        Topping Update(Topping topping);
        bool Delete(Guid identifier);
    }
}
