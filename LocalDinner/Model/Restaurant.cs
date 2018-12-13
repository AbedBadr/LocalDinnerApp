using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LocalDinner.Model;

namespace LocalDinner
{
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Table> Tables { get; set; }
        public Calendar _Calendar { get; set; }

        private static int IdRef = 0;

        public Restaurant(string name = null, string city = null, int noOfSeats = 0) 
        {
            Id = Interlocked.Increment(ref IdRef);
            Name = name;
            City = city;
            Tables = new List<Table>();
        }
    }
}
