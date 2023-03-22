using Formation_TP1.Dto;

namespace Formation_TP1.Services
{
    public interface IRestaurantServices
    {
        public restaurant AddRestaurant(restaurant  res);
        public restaurant RemoveRestaurant(string id);
        public restaurant UpdateRestaurant(restaurant res);
        public restaurant GetRestaurantById(string Id);
        public List<restaurant> getAllRestaurants();
    }
}
