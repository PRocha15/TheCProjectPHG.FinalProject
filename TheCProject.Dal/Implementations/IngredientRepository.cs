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
    public class IngredientRepository:IIngredientRepository
    {
        TheCProjectDbContext _dbContext;

        public IngredientRepository(TheCProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Ingredient> Ingredients => _dbContext.Ingredient;

        public bool Delete(Guid identifier)
        {
            Ingredient ingredient = _dbContext.Ingredient.Where(ingredient => ingredient.Identifier == identifier).First();
            _dbContext.Ingredient.Remove(ingredient);
            _dbContext.SaveChanges(true);
            return true;
        }

        public Ingredient Insert(Ingredient ingredient)
        {
            _dbContext.Ingredient.Add(ingredient);
            int res = _dbContext.SaveChanges();
            return ingredient;
        }

        public Ingredient Update(Ingredient ingredient)
        {
            _dbContext.Ingredient.Update(ingredient);
            _dbContext.SaveChanges();

            return ingredient;
        }
    }
}
