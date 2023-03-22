using Formation_TP1.Dto;
using Formation_TP1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formation_TP1.Pages.Restaurant
{
    public class detailModel : PageModel
    {
        private IRestaurantServices _restaurantServices;
        public restaurant Restaurant;
        public detailModel(IRestaurantServices restaurantServices)
        {
            this._restaurantServices = restaurantServices;
        }
        public void OnGet()
        {
            Restaurant = _restaurantServices.GetRestaurantById(Request.Query["id"].ToString());
        }
    }
}
