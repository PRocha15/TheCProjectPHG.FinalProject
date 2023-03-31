using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using TheCProject.Database.Context;
using Microsoft.Extensions.DependencyInjection;
using TheCProject.Database.DbEntities;
using TheCProject.Database.Seeds.Base;
using TheCProject.Database.DbEntities.Base;

namespace TheCProject.Database.Seeds
{
    public static class SeedDecoration
    {
        public static void PopulateDecorations(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if(!dbCtx.Decoration.Any())
            {
                List<Decoration> lst = new List<Decoration>()
                {
                    new Decoration
                    {
                        Name = "Fruit",
                        Price= 2
                    },
                    new Decoration
                    {
                        Name = "Chocolate",
                        Price= 2
                    },
                    new Decoration
                    {
                        Name = "Flowers",
                        Price= 2.5
                    },
                    new Decoration
                    {
                        Name = "Colored Sprinkles",
                        Price= 1.5
                    },
                    new Decoration
                    {
                        Name = "Dry Nuts",
                        Price= 3
                    },
                    new Decoration
                    {
                        Name = "Confettis",
                        Price= 1,
                    }

                };
                
                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Decoration.AddRange(lst);

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
