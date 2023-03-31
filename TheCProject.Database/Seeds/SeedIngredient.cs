using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;
using TheCProject.Database.Seeds.Base;

namespace TheCProject.Database.Seeds
{
    public static class SeedIngredient
    {
        public static void PopulateIngredients(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if (!dbCtx.Ingredient.Any())
            {
                List<Ingredient> lst = new List<Ingredient>()
                {
                    new Ingredient
                    {
                        Name = "Lot Bread",
                        Price= 6
                    },
                    new Ingredient
                    {
                        Name = "Genoise",
                        Price= 10
                    },
                    new Ingredient
                    {
                        Name = "Chiffon",
                        Price= 12
                    },
                    new Ingredient
                    {
                        Name = "Buttery",
                        Price= 8
                    },
                    new Ingredient
                    {
                        Name = "Without Flower",
                        Price= 15
                    },
                    new Ingredient
                    {
                        Name = "Yogurt",
                        Price= 9,
                    }

                };

                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Ingredient.AddRange(lst);

                try
                {
                    dbCtx.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
        }
    }
}
