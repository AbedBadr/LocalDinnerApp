using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LocalDinner
{
    //asd
    class Restaurant
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Category { get; set; }
        public int NumberOfSeats { get; set; }
        public string Telephone { get; set; }
        #endregion

        #region Constructor
        
        public Restaurant(int id, string name, string city, string category, int numberOfSeats, string telephone)
        {
            Id = id;
            Name = name;
            City = city;
            Category = category;
            NumberOfSeats = numberOfSeats;
            Telephone = telephone;
        }
        #endregion 

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(City)}: {City}, {nameof(Category)}: {Category}, {nameof(NumberOfSeats)}: {NumberOfSeats}, {nameof(Telephone)}: {Telephone}";
        }
    }
}
