using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class Table
    {
        public int Id { get; set; }
        public int NoSeats { get; set; }
        public bool Reserved { get; set; }

        public Table(int id, int noSeats, bool reserved)
        {
            Id = id;
            NoSeats = noSeats;
            Reserved = reserved;
        }
    }
}
