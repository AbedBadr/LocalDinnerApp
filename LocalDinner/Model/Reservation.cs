using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocalDinner.Model
{
    class Reservation
    {
        public DateTime Dato { get; set; }
        public int BookingNr { get; set; }
        public int AntalPladser { get; set; }
        public string Message { get; set; }

        private static int IdRef = 0;

        public Reservation(int antalPladser)
        {
            Dato = DateTime.Now;
            BookingNr = Interlocked.Increment(ref IdRef);
            AntalPladser = antalPladser;
        }

        public void Booking(int antalPladser, int AntalBooked)
        {
            if (AntalBooked < antalPladser)
                antalPladser = antalPladser - AntalBooked;

            if (AntalBooked > antalPladser)
                Message = "Der er ikke nok ledige pladser";
        }
    }
}
