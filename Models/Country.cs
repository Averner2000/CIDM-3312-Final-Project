namespace Final_Project.Models
{
    public class Country
    {
        public int CountryId {get;set;}
        public string CountryName{get;set;} = string.Empty;
        public string CountryNeighbor {get;set;} = string.Empty;
        public string Export {get;set;} = string.Empty;
        public string Import {get;set;} = string.Empty;
       
       //For founding country
        public int AllianceId {get;set;}
        public Allegiance? Allegiance {get;set;}
        public List<Allegiance> Allegiances {get;set;}

        //For Lair location
        public int DragonId {get; set;}
        public Dragon? Dragon {get;set;}
        public List<Dragon> Dragons {get;set;}



           }
}