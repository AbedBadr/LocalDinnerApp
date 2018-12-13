using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class Calendar
    {
        public DateTime Dato { get; set; }
        public Reservation Reservation { get; set; } 
        
        public Calendar(Reservation reservation)
        {
            Dato = DateTime.Now;
            Reservation = reservation;
        }
    }
}

    

