using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class ProvDisp
    {
        private String provRFC, modelo, precio;

        public String ProvRFC
        {
            get { return provRFC; }
            set { provRFC = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
