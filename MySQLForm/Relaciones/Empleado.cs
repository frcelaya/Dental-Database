using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySQLForm
{
    class Empleado
    {
        private String nss, nombre, apellido, dir, fingreso, telefono, celular, email, horaen, horasal, salario;

        public String Nss
        {
            get { return nss; }
            set { nss = value; }
        }

        public string Nombre
        {
            get{return nombre;}
            set{nombre = value;}
        }

        public String Apellido
        {
            get{return apellido;}
            set{apellido = value;}
        }

        public String Direccion
        {
            get { return dir; }
            set { dir = value; }
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

        public String Horaen
        {
            get { return horaen; }
            set { horaen = value; }
        }

        public String Horasal
        {
            get { return horasal; }
            set { horasal = value; }
        }

        public String Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}
