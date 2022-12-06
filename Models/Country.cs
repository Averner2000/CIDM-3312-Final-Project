namespace Final_Project.Models
{
    public class Country
    {
        public int CountryId {get;set;}
        public string CountryName{get;set;} = string.Empty;
        public string CountryNeighbor {get;set;} = string.Empty;
        public string Export {get;set;} = string.Empty;
        public string Import {get;set;} = string.Empty;
        public Allegiance? AllianceName {get;set;}

        public List<Dragon> Dragons {get;set;} = new List<Dragon>();

        public List<Allegiance> Allegiances {get;set;} = new List<Allegiance>();
    }
}