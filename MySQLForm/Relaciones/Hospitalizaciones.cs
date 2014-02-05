using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Hospitalizaciones
    {
        private String rfcPaciente, consecutivo, motivo, fecha;

        public String RFCPaciente
        {
            get { return rfcPaciente; }
            set { rfcPaciente = value; }
        }

        public String Consecutivo
        {
            get { return consecutivo; }
            set { consecutivo = value; }
        }

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
