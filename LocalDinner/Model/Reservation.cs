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

        private int _bookingNr = 0;

        #endregion

        #region Properties

        public DateTime Dato { get; set; }
        public int BookingNr
        {
            get { return _bookingNr; }
            set { _bookingNr = value; }
        }
        public int AntalPladser { get; set; }
        #endregion

        #region Constructor

        public Reservation(int antalPladser)
        {
            Dato = DateTime.Today;
            BookingNr = BookingNr++;
            AntalPladser = antalPladser;
        }
        #endregion

        #region Methods


        #endregion
    }
}
