using Formation_TP1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_TP1.Pages.Restaurant
{
    public class deleteModel : PageModel
    {
        private readonly IRestaurantServices _restaurantService;

        public deleteModel(IRestaurantServices restaurantService)
        {
            _restaurantService = restaurantService;
        }
        public IActionResult OnGet()
        {
            _restaurantService.RemoveRestaurant(Request.Query["id"].ToString());
            return RedirectToPage("/Index");

        }
    }
}
