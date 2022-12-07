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
        public Country? CountryName {get; set;} 

        public List<Country> Countrys {get;set;} = new List<Country>();

        public List<Dragon> Dragons {get;set;} = new List<Dragon>();

    }
}