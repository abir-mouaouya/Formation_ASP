using Formation_TP1.Dto;
using Formation_TP1.Services;

namespace Formation_TP1.Repository
{
    public class Repository 
    {  
        public static Repository Instance { get; set; }

        public List<restaurant> Restaurants { get; set; } = new List<restaurant>(){
            (new restaurant() { Id = "1", Name = "Restaurant 1", Address = "Address 1", cuisine = "cuisine 1" }),
            (new restaurant() { Id = "2", Name = "Restaurant 2", Address = "Address 2", cuisine = "cuisine 2" }),
            (new restaurant() { Id = "3", Name = "Restaurant 3", Address = "Address 3", cuisine = "cuisine 3" }),
            (new restaurant() { Id = "4", Name = "Restaurant 4", Address = "Address 4", cuisine = "cuisine 4" }),
            (new restaurant() { Id = "5", Name = "Restaurant 5", Address = "Address 5", cuisine = "cuisine 5" }) };



        public static Repository GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Repository();
            }
            return Instance;
        }

    }
}
