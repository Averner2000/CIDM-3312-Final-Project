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
  

        //For Lair location
        public List<Dragon>? Dragons {get;set;}



        }
}