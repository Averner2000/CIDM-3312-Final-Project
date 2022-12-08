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


/* class attrabute keys
                    new Dragon {
                        DragonName = "",
                        DragonRace = "",
                        DragonEC = "",
                        DragonAffinity = "",
                        DragonBounty =  ,
Lair location (FK)      CountryName = "",
Alligned with (FK)      AllianceName = "",
                        DragonBounty = 
                    },

                    new Country{
                        CountryName = "",
                        CountryNeighbor = "",
                        Export = "",
                        Import = "",
        (FK)            AllianceName = ""
                    },

                    new Allegiance {
                        AllianceName = "",
                        AllyStatus = "",
                        WarStatus = ""
                    },




*/


/*
                context.Dragon.AddRange(
                    new Dragon {
                        DragonName = "",
                        DragonRace = "",
                        DragonEC = "",
                        DragonAffinity = "",
                        DragonBounty =  ,
                        CountryName = "",
                        AllianceName = "",
                        DragonBounty = 
                    },





                );



            }
        }
    }
}

*/