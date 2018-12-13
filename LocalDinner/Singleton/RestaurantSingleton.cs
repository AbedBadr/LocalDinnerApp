using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class RestaurantSingleton
    {
        private static RestaurantSingleton _instance;

        public static RestaurantSingleton Instance
        {
            get { return _instance ?? (_instance = new RestaurantSingleton()); }
        }

        public ObservableCollection<Restaurant> Restaurants { get; set; }
        
        private RestaurantSingleton()
        {
            Restaurants = new ObservableCollection<Restaurant>();
            LoadRestaurants();
        }

        public void LoadRestaurants()
        {
            Restaurants.Add(new Restaurant("Flammen", "Roskilde", 50));
            Restaurants.Add(new Restaurant("Ilden", "Roskilde", 70));
            Restaurants.Add(new Restaurant("Moehr", "Roskilde", 60));
            Restaurants.Add(new Restaurant("Bone's", "Roskilde", 50));
            Restaurants.Add(new Restaurant("La Rustica", "Roskilde", 60));
            Restaurants.Add(new Restaurant("Maher", "København", 60));
            Restaurants.Add(new Restaurant("Michel", "København", 70));
            Restaurants.Add(new Restaurant("Alex", "København", 50));
        }
    }
}
