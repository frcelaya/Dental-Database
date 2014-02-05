using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Paciente
    {
        private String rfc, nombre, apellido, email, edocivil, fnac, fingreso, telefono, celular;

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

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Fnac
        {
            get { return fnac; }
            set { fnac = value; }
        }

        public String Fingreso
        {
            get { return fingreso; }
            set { fingreso = value; }
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

        public String Edocivil
        {
            get { return edocivil; }
            set { edocivil = value; }
        }
    }
}
