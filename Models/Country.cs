namespace Final_Project.Models
{
    public class Country
    {
        public int CountryId {get;set;}
        public string CountryName{get;set;} = string.Empty;
        public string CountryNeighbor {get;set;} = string.Empty;
        public string Export {get;set;} = string.Empty;
        public string Import {get;set;} = string.Empty;
       
       
        public int AllianceId {get;set;}
        public Allegiance? Allegiance {get;set;}
        public List<Allegiance> Allegiances {get;set;}


        public int DragonId {get; set;}
        public Dragon? Dragon {get;set;}
        public List<Dragon> Dragons {get;set;}



           }
}