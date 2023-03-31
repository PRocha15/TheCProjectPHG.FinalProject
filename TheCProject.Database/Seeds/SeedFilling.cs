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
    public static class SeedFilling
    {
        public static void PopulateFillings(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if (!dbCtx.Filling.Any())
            {
                List<Filling> lst = new List<Filling>()
                {
                    new Filling
                    {
                        Name = "Fruit compote",
                        Price= 2
                    },
                    new Filling
                    {
                        Name = "Custard",
                        Price= 2
                    },
                    new Filling
                    {
                        Name = "Nutella",
                        Price= 2.5
                    },
                    new Filling
                    {
                        Name = "Mascarpone",
                        Price= 3
                    }
                };

                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Filling.AddRange(lst);

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
