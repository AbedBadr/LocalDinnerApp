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

        #endregion

        #region Constructor

        public Calendar()
        {
            Dato = DateTime.Today;

        }
        #endregion


    }
}

    

