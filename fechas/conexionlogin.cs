using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace fechas
{
    class conexionlogin
    {
        public static MySqlConnection cnx = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;");
        public static void comprobarconexion()
        {
            try
            {
                cnx.Open();
                MessageBox.Show("Conectado");
                cnx.Close();
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
                throw;

            }
            finally { cnx.Close(); }

        }
    }
}
