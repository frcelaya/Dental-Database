using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Alergias
    {
        private String rfcPaciente, alergia, motivo, fecha;

        public String RFCPaciente
        {
            get { return rfcPaciente; }
            set { rfcPaciente = value; }
        }

        public String Alergia
        {
            get { return alergia; }
            set { alergia = value; }
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
