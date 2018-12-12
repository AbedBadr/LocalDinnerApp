using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalDinner.Model;

namespace LocalDinner
{
    class Restaurant
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int NoOfSeats { get; set; }
        private Calendar Calendar1;

        #endregion

        #region Constructor
        
        public Restaurant(int id, string name, string city, int noOfSeats) 
        {
            Id = id;
            Name = name;
            City = city;
            Calendar1.Reservation1.AntalPladser = noOfSeats;
            NoOfSeats = Calendar1.Reservation1.AntalPladser;
        }
        #endregion

        #region ToString

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(City)}: {City}, {nameof(NoOfSeats)}: {NoOfSeats}";
        }
        #endregion

        
    }
}
