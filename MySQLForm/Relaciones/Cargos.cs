using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm.Relaciones
{
    class Cargos
    {
        private String numCargo, numMov, rfcPac, monto, fecha;

        public String NumCargo
        {
            get { return numCargo; }
            set { numCargo = value; }
        }

        public String NumMov
        {
            get { return numMov;}
            set { numMov = value;}
        }

        public String RfcPac
        {
            get { return rfcPac; }
            set { rfcPac = value; }
        }

        public String Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
