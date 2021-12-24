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
using MySql.Data;
using System.Security.Principal;

namespace fechas
{

    public partial class inicioseccion : Form
    {
        
        public inicioseccion()
        {
            InitializeComponent();
             
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cnx = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;");
                string query = "Select * from login where username = '" + txtuser.Text + "' and password= '" + txtpass.Text + "' ";
                
                MySqlDataAdapter Comando = new MySqlDataAdapter(query, cnx);
                DataTable dt = new DataTable();
                Comando.Fill(dt);
                
                if (dt.Rows.Count == 1)
                {
                    MenuHome objmenuhome = new MenuHome();
                    Usulogueado.usuarioLogeado = txtuser.Text;
                    objmenuhome.varf1 = txtuser.Text;
                    objmenuhome.varf2 = lbfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    objmenuhome.varf3 = lbhora.Text = DateTime.Now.ToShortTimeString();
                 

                    objmenuhome.Visible = true;
                    Visible = false;
                    conexionlogin.comprobarconexion();
                }


                else
                {

                    MessageBox.Show("Error: Usuerio o contraseña incorrecto.");
                }
                //lbuserr.Text = user.Name;
               
        }


    }
}
