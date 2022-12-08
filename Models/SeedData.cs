using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DragonContext(serviceProvider.GetRequiredService<DbContextOptions<DragonContext>>()))
            {
                if (context.Dragons.Any())
                {
                    return;
                }

//Dragons
                context.Dragons.AddRange(
                    new Dragon {
                        DragonName = "Dayyelsun",
                        DragonRace = "Western dragon",
                        DragonEC = "N/A",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 0,
                        AllegianceId = 0

                    }, 
                    new Dragon {
                        DragonName = "monsoon",
                        DragonRace = "Wyvern",
                        DragonEC = "Lightning",
                        DragonAffinity = "Chaotic Good",
                        DragonBounty = 5000 ,
                        CountryId = 1,
                        AllegianceId = 0
                    }
                );

//countrys
                context.Countrys.AddRange(
                    new Country {
                        CountryName = "N/A (Nomadic)",
                        CountryNeighbor = "N/A",
                        Export = "N/A",
                        Import = "N/A",

                    },
                    new Country {
                        CountryName = "Colae",
                        CountryNeighbor = "N/A (Island)",
                        Export = "Fish",
                        Import = "Spices"
                    },
                    new Country {
                        CountryName = "Roclu",
                        CountryNeighbor = "N/A (Island)",
                        Export = "Spices",
                        Import = "Raw Materials"
                    },
                    new Country {
                        CountryName = "Masarthai",
                        CountryNeighbor = "N/A (Island)",
                        Export = "Raw Materials",
                        Import = "Fish"
                    }
                );

//Allegiance
                context.Allegiances.AddRange(
                    new Allegiance {
                        AllianceName = "N/A",
                        AllyStatus = "N/A",
                        WarStatus = "N/A"
                    },
                    new Allegiance {
                        AllianceName = "Ocenaic Island Alliance",
                        AllyStatus = "N/A",
                        WarStatus = "N/A"
                    }
                );

                context.SaveChanges();
            }
        }
    }
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