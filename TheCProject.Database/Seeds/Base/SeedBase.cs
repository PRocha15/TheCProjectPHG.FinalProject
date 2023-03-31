using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using TheCProject.Database.Context;
using Microsoft.Extensions.DependencyInjection;
using TheCProject.Database.DbEntities;
using Microsoft.EntityFrameworkCore;
using TheCProject.Database.DbEntities.Base;

namespace TheCProject.Database.Seeds.Base
{
    public static class SeedBase
    {
        public static TheCProjectDbContext DbContext(IApplicationBuilder app)
        {
            var dbCtx = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<TheCProjectDbContext>();

            if (dbCtx.Database.GetPendingMigrations().Any())
            {
                dbCtx.Database.Migrate();
            }
            return dbCtx;

        }
        public static void PopulateBase(BaseEntity entity)
        {
            entity.CreateDate= DateTime.Now;
            entity.UpdateDate = DateTime.Now;
            entity.CreateUser = "System";
            entity.UpdateUser = "System";
            entity.Identifier = Guid.NewGuid();


        }
    }
}
