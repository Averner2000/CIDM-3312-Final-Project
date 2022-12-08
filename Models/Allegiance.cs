namespace Final_Project.Models
{
    public class Allegiance
    {
        public int AllianceId {get;set;}

        public string AllianceName {get;set;} = string.Empty;

        //Ally status with other alliances, and countries
        public string AllyStatus {get; set;} = string.Empty;
        //War status with other alliances, and countries
        public string WarStatus {get; set;} = string.Empty;

        //Founder country
        public int CountryId {get; set;}

         public Country? Country {get;set;}

         public List<Country> Countrys {get;set;}
 

        public int DragonId {get; set;}
        public Dragon? Dragon {get;set;}
        public List<Dragon> Dragons {get;set;}



        


    }
}