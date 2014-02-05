using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Consultorio
{
    public class Buscar
    {
        public Buscar() { }
        public DataSet Busqueda(string query, string search)
        {
            Conecta c = new Conecta();
            DataSet datos = new DataSet();
            datos = c.Actualizar(query, search);
            return datos;
        }
    }
}
