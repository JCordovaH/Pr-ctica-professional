using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace fechas
{
    class DALFechas
    {


        public static int Agregarmensual(Fechas pfechas)
        {
            int retorno = 0;
     

                using (MySqlConnection Conn = BDcomun.ObtnerCOnexion())
                {
                    MySqlCommand Comando = new MySqlCommand(string.Format(@"INSERT INTO compromisoss (nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago) 
                                                                                    SELECT '{0}', '{1}', NULL, ADDDATE('{3}', INTERVAL SomeNumber month), '{4}', null, null 
                                                                                    FROM (SELECT a.i+b.i*10+c.i*100+d.i*1000 AS SomeNumber FROM enteros a, enteros b, enteros c, enteros d) Sub1 WHERE SomeNumber BETWEEN 0 AND @cantidad",
                    pfechas.nomcompromiso, pfechas.plazo, pfechas.fdepago, pfechas.fcaducidad, pfechas.valordecuota, pfechas.pago, pfechas.formadepago, pfechas.cantidad), Conn);

                    Comando.Parameters.AddWithValue("@cantidad", pfechas.cantidad);
                    retorno = Comando.ExecuteNonQuery();
                    Conn.Close();

                }

            return retorno;
        }

        public static int AgregarTrimestral(Fechas pfechas)
        {
            int retorno = 0;


            using (MySqlConnection Conn = BDcomun.ObtnerCOnexion())
            {
                MySqlCommand Comando = new MySqlCommand(string.Format(@"INSERT INTO compromisoss (nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago) 
                                                                                    SELECT '{0}', '{1}', NULL, ADDDATE('{3}', INTERVAL SomeNumber quarter), '{4}', null, null 
                                                                                    FROM (SELECT a.i+b.i*10+c.i*100+d.i*1000 AS SomeNumber FROM enteros a, enteros b, enteros c, enteros d) Sub1 WHERE SomeNumber BETWEEN 0 AND @cantidad",
                pfechas.nomcompromiso, pfechas.plazo, pfechas.fdepago, pfechas.fcaducidad, pfechas.valordecuota, pfechas.pago, pfechas.formadepago, pfechas.cantidad), Conn);

                Comando.Parameters.AddWithValue("@cantidad", pfechas.cantidad);
                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }

            return retorno;
        }

        public static int AgregarAnual(Fechas pfechas)
        {
            int retorno = 0;


            using (MySqlConnection Conn = BDcomun.ObtnerCOnexion())
            {
                MySqlCommand Comando = new MySqlCommand(string.Format(@"INSERT INTO compromisoss (nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago) 
                                                                                    SELECT '{0}', '{1}', NULL, ADDDATE('{3}', INTERVAL SomeNumber year), '{4}', null, null 
                                                                                    FROM (SELECT a.i+b.i*10+c.i*100+d.i*1000 AS SomeNumber FROM enteros a, enteros b, enteros c, enteros d) Sub1 WHERE SomeNumber BETWEEN 0 AND @cantidad",
                pfechas.nomcompromiso, pfechas.plazo, pfechas.fdepago, pfechas.fcaducidad, pfechas.valordecuota, pfechas.pago, pfechas.formadepago, pfechas.cantidad), Conn);

                Comando.Parameters.AddWithValue("@cantidad", pfechas.cantidad);
                retorno = Comando.ExecuteNonQuery();
                Conn.Close();

            }

            return retorno;
        }


        public static List<Fechas> fdepagovacias(String pnomcompromiso)
        {
            List<Fechas> Lista = new List<Fechas>();
            using (MySqlConnection conexion = BDcomun.ObtnerCOnexion())
            {
                
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Select idCompromisoss, nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago FROM compromisoss WHERE fdepago is NULL", pnomcompromiso), conexion);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Fechas pfechas = new Fechas();
                    pfechas.idcompromiso = reader.GetInt64(0);
                    pfechas.nomcompromiso = reader.GetString(1);
                    pfechas.plazo = reader.GetString(2);
                    pfechas.fdepago = Convert.ToString(reader.GetValue(3));
                    pfechas.fcaducidad = Convert.ToString(reader.GetValue(4));
                    pfechas.valordecuota = reader.GetString(5);
                    pfechas.pago = Convert.ToString(reader.GetValue(6));
                    pfechas.formadepago = Convert.ToString(reader.GetValue(7));

                    Lista.Add(pfechas);

                }
                conexion.Close();
                return Lista;

            }
        }




        public static List<Fechas> BuscarFechas(String pnomcompromiso, DateTime desde, DateTime hasta)
        {

            List<Fechas> Lista = new List<Fechas>();
            using (MySqlConnection conexion = BDcomun.ObtnerCOnexion())
            {
                
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Select idCompromisos, nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago from compromisoss where (nomcompromisos like '%{0}%') and (fcaducidad between @desde and @hasta) ", pnomcompromiso, desde, hasta), conexion);

                comando.Parameters.AddWithValue("@desde", desde);
                comando.Parameters.AddWithValue("@hasta", hasta);
                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Fechas pfechas = new Fechas();
                    pfechas.idcompromiso = reader.GetInt64(0);
                    pfechas.nomcompromiso = reader.GetString(1);
                    pfechas.plazo = reader.GetString(2);
                    pfechas.fdepago = Convert.ToString(reader.GetValue(3));
                    pfechas.fcaducidad = Convert.ToString(reader.GetValue(4));
                    pfechas.valordecuota = reader.GetString(5);
                    pfechas.pago = Convert.ToString(reader.GetValue(6));
                    pfechas.formadepago = Convert.ToString(reader.GetValue(7));

                    Lista.Add(pfechas);

                }
                conexion.Close();
                return Lista;

            }

        }


    

        public static Fechas Obtenerfecha(Int64 pidcompromiso)
        {

            using (MySqlConnection conexion = BDcomun.ObtnerCOnexion())
            {

                Fechas pfechas = new Fechas();
                MySqlCommand comando = new MySqlCommand(string.Format(
                    "Select idCompromisos, nomcompromisos, tipodeplazo, fdepago, fcaducidad, valordecuota, pago, formadepago from compromisoss where idCompromisos={0}", pidcompromiso), conexion);

                MySqlDataReader reader = comando.ExecuteReader();
                
           

                while (reader.Read())
                {
                    pfechas.idcompromiso = reader.GetInt64(0);
                    pfechas.nomcompromiso = reader.GetString(1);
                    pfechas.plazo = reader.GetString(2);
                    pfechas.fdepago = Convert.ToString(reader.GetValue(3));
                    pfechas.fcaducidad = Convert.ToString(reader.GetValue(4));
                    pfechas.valordecuota = reader.GetString(5);
                    pfechas.pago = Convert.ToString(reader.GetValue(6));
                    pfechas.formadepago = Convert.ToString(reader.GetValue(7));
                             

                }
                conexion.Close();
                return pfechas;

            }

        }


        public static int Modificar(Fechas pfechas)
        {
            int retorno = 0;
            using (MySqlConnection conexion = BDcomun.ObtnerCOnexion())
            {
                MySqlCommand comando = new MySqlCommand(string.Format("Update compromisoss set nomcompromisos='{0}', tipodeplazo='{1}', fdepago='{2}', fcaducidad='{3}', valordecuota='{4}', pago='{5}', formadepago='{6}' where idCompromisos={7}",
                    pfechas.nomcompromiso, pfechas.plazo, pfechas.fdepago, pfechas.fcaducidad, pfechas.valordecuota, pfechas.pago, pfechas.formadepago, pfechas.idcompromiso), conexion);

                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }




        public static int Eliminar(Int64 pidcompromiso)
        {
            int retorno = 0;
            using (MySqlConnection conexion = BDcomun.ObtnerCOnexion())
            {

                MySqlCommand comando = new MySqlCommand(string.Format("Delete from compromisoss where idCompromisos={0}", pidcompromiso), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;

        }
    
    }
}
