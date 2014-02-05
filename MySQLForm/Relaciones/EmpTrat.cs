using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm.Relaciones
{
    class EmpTrat
    {
        private String nsse, nombreTr, consecutivo, rfcPac, fecha;

        public String Nsse
        {
            get { return nsse; }
            set { nsse = value; }
        }

        public String NombreTr
        {
            get { return nombreTr; }
            set { nombreTr= value; }
        }

        public String Consecutivo
        {
            get { return consecutivo; }
            set { consecutivo = value; }
        }

        public String RfcPac
        {
            get { return rfcPac; }
            set { rfcPac = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
