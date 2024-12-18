using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SoftUniGamesApp.Data;

namespace SoftUniGamesApp.Web.Infrastructure.Extensions
{
    public static class ExtensionMethods
    {
        public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();
            GamesDbContext dbContext = serviceScope.ServiceProvider.GetRequiredService<GamesDbContext>()!;
            dbContext.Database.Migrate();

            return app;
        }
    }
}
