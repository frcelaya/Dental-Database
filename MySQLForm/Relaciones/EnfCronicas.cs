using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class EnfCronicas
    {
        private String rfcPaciente, enfermedad, motivo;

        public String RFCPaciente
        {
            get { return rfcPaciente; }
            set { rfcPaciente = value; }
        }

        public String Enfermedad
        {
            get { return enfermedad; }
            set { enfermedad = value; }
        }

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
    }
}
