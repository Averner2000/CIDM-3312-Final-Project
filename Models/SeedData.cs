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
                        Import = "Raw Materials, Lumber"
                    },
                    new Country {
                        CountryName = "Masarthai",
                        CountryNeighbor = "N/A (Island)",
                        Export = "Raw Materials",
                        Import = "Fish"
                    },
                    new Country {
                        CountryName = "Artinoble",
                        CountryNeighbor = "Estonbar,",
                        Export = "Lumber",
                        Import = "Fish"
                    },
                    new Country {
                        CountryName = "Estonbar",
                        CountryNeighbor = "Artinoble, Lanroion",
                        Export = "Wine",
                        Import = "Lumber"
                    },
                    new Country {
                        CountryName = "Lanroion",
                        CountryNeighbor = "Estonbar, Swandle",
                        Export = "Refined Metals",
                        Import = "Coal, Raw Matierals"
                    },
                    new Country {
                        CountryName = "Swandle",
                        CountryNeighbor = "Estonbar",
                        Export = "Coal",
                        Import = "Refined Metals, Wine"
                    }

                );
                context.SaveChanges();
                

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
                    },
                    new Allegiance {
                        AllianceName = "The Dragonian Order",
                        AllyStatus = "The Highland Coilition",
                        WarStatus = "N/A"
                    },
                    new Allegiance {
                        AllianceName = "The Highland Coilition",
                        AllyStatus = "The Dragonian Order",
                        WarStatus = "The Kingdoms of Humainty and Prosperity"
                    },
                    new Allegiance {
                        AllianceName = "The Kingdoms of Humainty and Prosperity",
                        AllyStatus = "N/A",
                        WarStatus = "The Highland Coilition"
                    }
                );
                context.SaveChanges();



//Dragons
                context.Dragons.AddRange(
                    new Dragon {
                        DragonName = "Dayyelsun",
                        DragonRace = "Western dragon",
                        DragonEC = "N/A (No Elemental Control",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 1,
                        AllegianceId = 1

                    }, 
                    new Dragon {
                        DragonName = "Monsoon",
                        DragonRace = "Wyvern",
                        DragonEC = "Lightning",
                        DragonAffinity = "Chaotic Good",
                        DragonBounty = 5000 ,
                        CountryId = 2,
                        AllegianceId = 1
                    },
                    new Dragon {
                        DragonName = "Guardsord",
                        DragonRace = "Western dragon",
                        DragonEC = "Ice",
                        DragonAffinity = "Neutral Good",
                        DragonBounty = 0 ,
                        CountryId = 2,
                        AllegianceId = 2

                    }, 
                    new Dragon {
                        DragonName = "Iorntail",
                        DragonRace = "Drake",
                        DragonEC = "Fire",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 2,
                        AllegianceId = 3

                    }, 
                    new Dragon {
                        DragonName = "Talon",
                        DragonRace = "Wyvern",
                        DragonEC = "Shadow",
                        DragonAffinity = "Chaotic Evil",
                        DragonBounty = 50000 ,
                        CountryId = 1,
                        AllegianceId = 1

                    }, 
                    new Dragon {
                        DragonName = "Pedalwing",
                        DragonRace = "Fey Dragon",
                        DragonEC = "Earth",
                        DragonAffinity = "Neutral Good",
                        DragonBounty = 0 ,
                        CountryId = 3,
                        AllegianceId = 2

                    }, 
                    new Dragon {
                        DragonName = "Wavestriker",
                        DragonRace = "Sea Serpent",
                        DragonEC = "Water",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 2,
                        AllegianceId = 1

                    }, 
                    new Dragon {
                        DragonName = "Viper",
                        DragonRace = "Wyvern",
                        DragonEC = "Poison",
                        DragonAffinity = "Pure Neutral",
                        DragonBounty = 0 ,
                        CountryId = 3,
                        AllegianceId = 1

                    }, 
                    new Dragon {
                        DragonName = "Crystal",
                        DragonRace = "Western dragon",
                        DragonEC = "Elemental",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 1,
                        AllegianceId = 1

                    },
                    new Dragon {
                        DragonName = "Iornheart",
                        DragonRace = "Drake",
                        DragonEC = "Fire",
                        DragonAffinity = "Pure Neutral",
                        DragonBounty = 0 ,
                        CountryId = 5,
                        AllegianceId = 4
                    },
                    new Dragon {
                        DragonName = "Cinder",
                        DragonRace = "Wyvern",
                        DragonEC = "N/A",
                        DragonAffinity = "Lawful Good",
                        DragonBounty = 0 ,
                        CountryId = 6,
                        AllegianceId = 3
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