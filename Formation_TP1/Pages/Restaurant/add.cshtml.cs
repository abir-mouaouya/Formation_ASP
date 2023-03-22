using Formation_TP1.Dto;
using Formation_TP1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_TP1.Pages.Restaurant
{
    public class addModel : PageModel
    {
        
        [BindProperty]
        public restaurant Restaurant { get; set; }
        private readonly IRestaurantServices _restaurantService;
        public List<restaurant> restaurants;

        public addModel(IRestaurantServices restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _restaurantService.AddRestaurant(Restaurant);
            return RedirectToPage("Restaurant/list");

        }
    }
}
