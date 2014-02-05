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
    class Conecta
    {
        public Conecta() { }
        /*public DataSet Cargar(string tabla)
        {
            DataSet datos = new DataSet();
            datos = Actualizar(tabla, "select id_material, nombre, clasificacion, genero, status from material;");
            return datos;
        }*/

        public DataSet Actualizar(string tabla, string query)
        {
            DataSet datos = new DataSet();
            try
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=consultorio;" + "UID=root;" + "PASSWORD=ybtv3rlk;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlDataAdapter ensambla = new MySqlDataAdapter(query, connection);
                ensambla.Fill(datos, tabla);
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }
    }
}
