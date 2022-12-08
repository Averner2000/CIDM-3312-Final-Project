namespace Final_Project.Models
{
    public class Dragon
    {

        public int DragonId {get;set;}
        public string DragonName {get;set;} = string.Empty;
        public string DragonRace {get;set;} = string.Empty;
        public string DragonEC {get;set;} = string.Empty;
        public string DragonAffinity {get;set;} = string.Empty;
        public int DragonBounty {get;set;}



//      lair location 

        public int CountryId {get; set;}

         public Country? Country {get;set;}


//      Dragon's allegiance
        public int AllegianceId {get;set;}
        public Allegiance? Allegiance {get;set;}


        


        }
}