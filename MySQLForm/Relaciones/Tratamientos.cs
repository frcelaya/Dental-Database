using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultorio
{
    class Tratamientos
    {
        private String nombre, tipo, costo;

        public String Nombre
        {
            get { return nombre; }
            set { nombre= value; }
        }

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Costo
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
