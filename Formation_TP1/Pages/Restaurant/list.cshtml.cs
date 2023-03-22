using Formation_TP1.Dto;
using Formation_TP1.Repository;
using Formation_TP1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_TP1.Pages.Restaurant
{
    public class listModel : PageModel
    {
        public List<restaurant> Restaurants { get; set; }
        private readonly IRestaurantServices _services;
        public List<restaurant> restaurants;
       

        public listModel(IRestaurantServices services)
        {
            _services = services;
        }
        public void OnGet()
        {
            restaurants = _services.getAllRestaurants();

        }
    }
}
