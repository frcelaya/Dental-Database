using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySQLForm.Relaciones;

namespace Consultorio
{
    public partial class Form1 : Form
    {
        string query;
        Query agr = new Query();
        DataSet datos = new DataSet();
        Buscar b = new Buscar();

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            query = "Select p.nombre, p.telefono, p.celular, p.email, d.modelo, COUNT(d.numserie) "+
                    "from dispositivos d, proveedor p "+
                    "where modelo='"+comboBox1.SelectedItem.ToString()+"' "+
                    "and p.RFC in "+
                    "(Select provrfc from prov_disp pro where p.RFC = pro.provrfc and d.modelo=pro.modelo)"+
                    "group by modelo having COUNT(d.numserie)<"+numericUpDown1.Value.ToString()+";";
            datos = b.Busqueda("dispositivos", query);
            dataGridView1.Visible = true;
            dataGridView1.DataSource = datos.Tables["dispositivos"];
            MessageBox.Show("Listos los resultados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "LOAD DATA INFILE 'C:/Users/Fer/Desktop/Pacientes2.txt' INTO TABLE pacientes;";
                datos = b.Busqueda("pacientes", query);
                dataGridView2.Visible = true;
                MessageBox.Show("¡Lista cargada con éxito!");
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message.ToString(), "ERROR");
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "Select * From pacientes;";
            datos = b.Busqueda("pacientes", query);
            dataGridView2.DataSource = datos.Tables["pacientes"];
            MessageBox.Show("¡Listos los pacientes!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Trim() == "")
            {
                MessageBox.Show("¡No se especificó RFC!", "ERROR");
            }
            else
            {
                try
                {
                    query = "INSERT INTO consultorio.pacientes (RFC, nombre, apellido, fnac, fingreso, telefono, celular, email, edocivil)" 
                            +"VALUES ( '"+textBox9.Text.ToString().Trim()+"', "
                            +"'"+textBox8.Text.ToString().Trim()+"', "
                            + "'" + textBox7.Text.ToString().Trim() + "', "
                            + "'" + textBox6.Text.ToString().Trim() + "', "
                            + "'" + textBox10.Text.ToString().Trim() + "', "
                            + "'" + textBox5.Text.ToString().Trim() + "', "
                            + "'" + textBox4.Text.ToString().Trim() + "', "
                            + "'" + textBox3.Text.ToString().Trim() + "', "
                            + "'" + textBox2.Text.ToString().Trim() + "');";
                    datos = b.Busqueda("pacientes", query);
                    dataGridView1.Visible = true;
                    dataGridView2.DataSource = datos.Tables["pacientes"];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message.ToString(), "ERROR");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Trim() == "")
            {
                MessageBox.Show("¡No se especificó RFC!", "ERROR");
            }
            else
            {
                try
                {
                    query = "Delete from pacientes where RFC = '"+textBox9.Text.ToString().Trim()+"';";
                    datos = b.Busqueda("pacientes", query);
                    dataGridView1.Visible = true;
                    dataGridView2.DataSource = datos.Tables["pacientes"];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message.ToString(), "ERROR");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox9.Text.ToString().Trim() == "")
            {
                MessageBox.Show("¡No se especificó RFC!", "ERROR");
            }
            else if(textBox10.Text.ToString().Trim() == "" || textBox5.Text.ToString().Trim() == "" || 
                textBox4.Text.ToString().Trim() == "" || textBox3.Text.ToString().Trim() == "" || textBox2.Text.ToString().Trim() == "")
            {
                MessageBox.Show("¡Los campos de Fecha de Ingreso, Teléfono, Celular, Email y EdoCivil, están vacíos!", "ERROR");
            }
            else
            {
                try
                {
                    query = "Update pacientes set fingreso='" + textBox10.Text.ToString().Trim() +"',"
                                                                +"telefono='"+textBox5.Text.ToString().Trim()+"', "
                                                                +"celular='"+textBox4.Text.ToString().Trim()+"', "
                                                                +"email='"+textBox3.Text.ToString().Trim()+"', "
                                                                +"edocivil='"+textBox2.Text.ToString().Trim()+"'"
                                                                +"where RFC='"+textBox9.Text.ToString().Trim()+"';";
                    datos = b.Busqueda("pacientes", query);
                    dataGridView1.Visible = true;
                    dataGridView2.DataSource = datos.Tables["pacientes"];
                }
                catch (MySqlException x)
                {
                    MessageBox.Show(x.Message.ToString(), "ERROR");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                query = "Select * "+ 
                        "from pacientes p "+
                        "where p.RFC in "+
                            "(Select m.rfcpac "+
                            "from movimientos m "+
                            "group by m.rfcpac "+
                            "having sum(m.monto)>"+numericUpDown2.Value.ToString()+" and m.rfcpac in "+
                                "(Select e.rfcpac "+
                                "from emp_trat e "+
                                "where e.nombretr='"+comboBox2.SelectedItem.ToString()+"'));";
                datos = b.Busqueda("pacientes", query);
                dataGridView3.Visible = true;
                dataGridView3.DataSource = datos.Tables["pacientes"];
            }
            catch (MySqlException x)
            {
                MessageBox.Show(x.Message.ToString(), "ERROR");
            }
        }
    }
}