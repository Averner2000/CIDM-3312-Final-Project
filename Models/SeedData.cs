using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
/*
namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DragonDbContext(serviceProvider.GetRequiredService<DbContextOptions<DragonDbContext>>()))
            {
                if (context.Dragon.Any())
                {
                    return;
                }

                context.Dragon.AddRange(
                    new Dragon {
                        DragonName = "",


                    }
                );



            }
        }
    }
}

*/