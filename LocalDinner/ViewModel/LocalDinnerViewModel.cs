using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LocalDinner.Annotations;
using LocalDinner.Model;

namespace LocalDinner.ViewModel
{
    class LocalDinnerViewModel : INotifyPropertyChanged
    {
        #region Instance fields
        //private ObservableCollection<Restaurant> _restaurantCatalog;
        #endregion 

        #region Properties

        public RestaurantCatalogSingleton RestaurantCatalogSingleton { get; set; }

        /*public ObservableCollection<Restaurant> RestaurantCatalog
        {
            get { return _restaurantCatalog; }
            set { _restaurantCatalog = value; }
        }*/

        /*
         public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int NoOfSeats { get; set; }
        */
        #endregion

        #region Constructor
        public LocalDinnerViewModel()
        {
            RestaurantCatalogSingleton = RestaurantCatalogSingleton.Instance;

            /*RestaurantCatalog = new ObservableCollection<Restaurant>();
            RestaurantCatalog.Add(new Restaurant(1,"Restaurant Ilden", "Roskilde", 100));*/
        }
        #endregion

        #region Methods

        /*public void AddRestaurant()
        {
            RestaurantCatalog.Add(new Restaurant(Id, Name, City, NoOfSeats));
        }*/

        /*public void RemoveRestaurant()
        {
            RestaurantCatalog.RemoveAt(Id);
        }*/
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion 
    }
}
