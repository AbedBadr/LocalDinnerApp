using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class Reservation
    {
        #region Instance Fields

        #endregion

        #region Properties

        public DateTime Dato { get; set; }
        public int BookingNr { get; set; }
        public int AntalPladser { get; set; }
        public string Message { get; set; }
        #endregion

        #region Constructor

        public Reservation(int antalPladser)
        {
            Dato = DateTime.Today;
            BookingNr = 0;
            AntalPladser = antalPladser;
        }
        #endregion

        #region Methods

        public void Booking(int antalPladser, int AntalBooked)
        {
            if (AntalBooked < antalPladser)
            {
                antalPladser = antalPladser - AntalBooked;
                BookingNr++;
            }

            if (AntalBooked > antalPladser)
                Message = "Der er ikke nok ledige pladser";
        }
        #endregion
    }
}
