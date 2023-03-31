using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;

namespace TheCProject.Dal.Interfaces
{
    public interface IIngredientRepository
    {
        IQueryable<Ingredient> Ingredients { get; }

        Ingredient Insert(Ingredient ingredient);

        Ingredient Update(Ingredient ingredient);
        bool Delete(Guid identifier);
    }
}
