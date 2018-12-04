using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner
{
    class Restaurant
    {
        #region Properties
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int NumberOfSeats { get; set; }
        public string Telephone { get; set; }
        #endregion

        #region Constructor
        
        public Restaurant(string name, string city, string category, int numberOfSeats, string telephone)
        {
            Name = name;
            City = city;
            Category = category;
            NumberOfSeats = numberOfSeats;
            Telephone = telephone;
        }
        #endregion 

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(City)}: {City}, {nameof(Category)}: {Category}, {nameof(NumberOfSeats)}: {NumberOfSeats}, {nameof(OpeningHours)}: {OpeningHours}";
        }
    }
}
