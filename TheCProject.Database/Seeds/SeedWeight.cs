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
    public static class SeedWeight
    {
        public static void PopulateWeights(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if (!dbCtx.Weight.Any())
            {
                List<Weight> lst = new List<Weight>()
                {
                    new Weight
                    {
                        Name = "1 Kg",
                        Price= 10
                    },
                    new Weight
                    {
                        Name = "1.5 Kg",
                        Price= 15
                    },
                    new Weight
                    {
                        Name = "2 Kg",
                        Price= 20
                    }
                };

                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Weight.AddRange(lst);

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
