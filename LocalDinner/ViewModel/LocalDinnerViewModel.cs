using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LocalDinner.Annotations;
using LocalDinner.Helpers;
using LocalDinner.Model;

namespace LocalDinner.ViewModel
{
    class LocalDinnerViewModel : INotifyPropertyChanged
    {
        public RestaurantSingleton RestaurantSingleton { get; set; }

        private Restaurant _newRestaurant;
        private Restaurant _selectedRestaurant;

        public RelayCommand AddCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }

        public ObservableCollection<Restaurant> RestaurantCatalog
        {
            get { return RestaurantSingleton.Restaurants; }
            set { RestaurantSingleton.Restaurants = value; }
        }

        public Restaurant NewRestaurant
        {
            get => _newRestaurant;
            set
            {
                _newRestaurant = value;
                OnPropertyChanged();
            }
        }

        public Restaurant SelectedRestaurant
        {
            get => _selectedRestaurant;
            set
            {
                _selectedRestaurant = value;
                OnPropertyChanged();
            }
        }

        public LocalDinnerViewModel()
        {
            RestaurantSingleton = RestaurantSingleton.Instance;

            NewRestaurant = new Restaurant();

            AddCommand = new RelayCommand(() =>
            {
                RestaurantCatalog.Add(NewRestaurant);
            });

            DeleteCommand = new RelayCommand(() => { RestaurantCatalog.Remove(SelectedRestaurant); });

            SaveCommand = new RelayCommand(() => { SelectedRestaurant = null; });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
