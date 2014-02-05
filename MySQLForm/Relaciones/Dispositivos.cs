using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Dispositivos
    {
        private String modelo, numSerie, fechaCal;

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String NumSerie
        {
            get { return numSerie; }
            set { numSerie = value; }
        }

        public String FechaCal
        {
            get { return fechaCal; }
            set { fechaCal = value; }
        }
    }
}
