using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class RestaurantCatalogSingleton
    {
        #region Singleton instance

        private static RestaurantCatalogSingleton _instance;
        #endregion

        #region Singleton property

        public static RestaurantCatalogSingleton Instance
        {
            get { return _instance ?? (_instance = new RestaurantCatalogSingleton()); }
        }
        #endregion

        #region Properties

        public ObservableCollection<Restaurant> Restaurants { get; set; }
        public ObservableCollection<Restaurant> RestaurantsCity { get; set; }
        #endregion

        #region Constructor

        private RestaurantCatalogSingleton()
        {
            Restaurants = new ObservableCollection<Restaurant>();
            RestaurantsCity = new ObservableCollection<Restaurant>();
            LoadRestaurants();
        }
        #endregion

        #region Methods

        public void LoadRestaurants()
        {
            Restaurants.Add(new Restaurant(1, "Flammen", "Roskilde", 50));
            Restaurants.Add(new Restaurant(2, "Ilden", "Roskilde", 70));
            Restaurants.Add(new Restaurant(3, "Moehr", "Roskilde", 60));
            Restaurants.Add(new Restaurant(4, "Bone's", "Roskilde", 50));
            Restaurants.Add(new Restaurant(5, "La Rustica", "Roskilde", 60));
        }

        public void RoskildeRestauranter(string cityName)
        {
            foreach (Restaurant restaurant in Restaurants)
            {
                if (restaurant.City == cityName)
                    RestaurantsCity.Add(restaurant);
            }
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            Restaurants.Add(restaurant);
        }

        public void RemoveRestaurant(Restaurant restaurant)
        {
            Restaurants.RemoveAt(restaurant.Id);
        }


        #endregion 
    }
}
