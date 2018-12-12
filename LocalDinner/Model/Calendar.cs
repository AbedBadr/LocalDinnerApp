using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class Calendar
    {
        #region Properties

        public DateTime Dato { get; set; }
        public int AktuelAntalPladser { get; set; }
        private Reservation _reservation1; 

        public Reservation Reservation1 { get; set; }
        #endregion

        #region Constructor

        public Calendar(Reservation reservation)
        {
            Dato = DateTime.Today;
            reservation1 = reservation;

        }
        #endregion


    }
}

    

