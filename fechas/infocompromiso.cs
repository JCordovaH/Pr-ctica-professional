using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fechas
{
    public partial class infocompromiso : Form
    {
        MySqlConnection connection = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;");
        public infocompromiso()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MenuHome menu = new MenuHome();
            //menu.Visible = true;
            Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO infocompromisos(nombrecompromiso,nombreEmpresa,fono,direccion,email) VALUES('" + txtnomcompromiso.Text + "','" + txtnomempresa.Text + "','" + txtfono.Text + "','" + txtdireccion.Text + "','" + txtemail.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE test_db.users SET fname = '" + txtnomcompromiso.Text + "', lname = '" + txtnomempresa.Text + "', age = " + int.Parse(txtfono.Text) + " WHERE id=" + int.Parse(txtdireccion.Text);

            connection.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(updateQuery, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void infocompromiso_Load(object sender, EventArgs e)
        {

        }
    }
}
