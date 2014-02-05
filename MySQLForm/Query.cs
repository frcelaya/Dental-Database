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
    class Query
    {
        public Query() { }
        public void Agregar(string query)
        {
            string Mcdb = "SERVER=localhost;" + "DATABASE=consultorio;" + "UID=root;" + "PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(Mcdb);
            connection.Open();
            try
            {
                MySqlCommand line = new MySqlCommand(query, connection);
                line.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Ultimo(string query)
        {
            string resultado="";
            return resultado;
        }
    }
}
