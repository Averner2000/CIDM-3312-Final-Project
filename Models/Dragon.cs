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
        public Country? CountryName {get; set;} 
//      Dragon's allegiance
        public Allegiance? AllianceName {get;set;}

        


        }
}