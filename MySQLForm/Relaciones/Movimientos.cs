using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm.Relaciones
{
    class Movimientos
    {
        private String numero, rfcPac, saldo;

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String RfcPac
        {
            get { return rfcPac; }
            set { rfcPac = value; }
        }

        public String Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}
