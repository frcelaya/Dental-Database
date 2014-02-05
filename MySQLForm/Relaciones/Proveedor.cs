using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Proveedor
    {
        private String rfc, nombre, direccion, telefono, celular, email;

        public String RFC
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
