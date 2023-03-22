using Formation_TP1.Dto;
using Formation_TP1.Repository;

namespace Formation_TP1.Services
{
    public class RestaurantServices   :  IRestaurantServices
    {

        List<restaurant> restaurants = Repository.Repository.GetInstance().Restaurants;
     
        public restaurant AddRestaurant(restaurant restaurant)
        {

          //  restaurant.Id = Guid.NewGuid().ToString();
            restaurant.Id = (restaurants.Count + 1).ToString();
            restaurants.Add(restaurant);
            return GetRestaurantById(restaurant.Id);
        }

        public restaurant GetRestaurantById(string  id) => restaurants.FirstOrDefault(r => r.Id == id);

        public List<restaurant> getAllRestaurants() => restaurants;


        public restaurant RemoveRestaurant(string id)
        {
            var restaurant = GetRestaurantById(id);

            if (restaurant != null)
            {
                restaurants.Remove(restaurant);
            }

            return restaurant;


        }

        public restaurant UpdateRestaurant(restaurant newRestaurant)
        {
            var restaurant = GetRestaurantById(newRestaurant.Id);

            if (restaurant != null)
            {
                restaurant.Name = newRestaurant.Name;
                restaurant.Address = newRestaurant.Address;
                restaurant.cuisine = newRestaurant.cuisine;
            }
            return restaurant;
        }


    }
}
