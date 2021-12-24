using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace fechas
{
    class BDcomun
    {
        public static MySqlConnection ObtnerCOnexion()
        {
            MySqlConnection cnn = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;");

            cnn.Open();
            return cnn;

        }
    }
}
