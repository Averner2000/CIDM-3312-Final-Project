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

 
        //Found dragon allegiance
        public List<Dragon> Dragons {get;set;}



        


    }
}