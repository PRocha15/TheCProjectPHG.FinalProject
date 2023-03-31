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
    public static class SeedTopping
    {
        public static void PopulateToppings(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if (!dbCtx.Topping.Any())
            {
                List<Topping> lst = new List<Topping>()
                {
                    new Topping
                    {
                        Name = "Ganache",
                        Price= 4
                    },
                    new Topping
                    {
                        Name = "Mascarpone",
                        Price= 5
                    },
                    new Topping
                    {
                        Name = "Fondant",
                        Price= 4
                    },
                    new Topping
                    {
                        Name = "Buttercream",
                        Price= 3
                    },
                    new Topping
                    {
                        Name = "Meringue",
                        Price= 3
                    }

                };

                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Topping.AddRange(lst);

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
