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

        //public Calendar Calendar { get; set; }
        #endregion

        #region Constructor
        
        public Restaurant(int id, string name, string city, int noOfSeats /*, Calendar calendar*/) 
        {
            Id = id;
            Name = name;
            City = city;
            NoOfSeats = noOfSeats;
            //Calendar = calendar;
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
