using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace fechas
{
    public partial class Registrocompromiso : Form
    {
        public Registrocompromiso()
        {
            InitializeComponent(); 
        }
        public string varf1;
        public string varf2;
        public string varf3;

        void limpiar()
        {
            txtnomcompr.SelectedIndex = -1;
            txtplazo.SelectedIndex = -1;
            txtfdeplazo.CustomFormat = " ";
            txtfcaducidad.CustomFormat = " ";
            txtvalorcuota.Clear();
            txtpago.Clear();
            txtformapago.SelectedIndex = -1;
        }

       
        public Fechas FechaActual { get; set; }

                 
        public void Registrocompromiso_Load(object sender, EventArgs e)
        {
            MenuHome menuinfo = new MenuHome();
            labeluser.Text = Usulogueado.usuarioLogeado; 
 
            this.txtformapago.Items.Add("Factura");
            this.txtformapago.Items.Add("Boleta");


            txtplazo.Items.Insert(0, "Mensual");
            txtplazo.Items.Insert(1, "Trimestral");
            txtplazo.Items.Insert(2, "Anual");
     
            txtfdeplazo.Visible = false;

            using (MySqlConnection cnn = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;"))
            {
                cnn.Open();

                string query = "select nombrecompromiso  from infocompromisos";

                MySqlDataAdapter da = new MySqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txtnomcompr.DataSource = dt;
                txtnomcompr.DisplayMember = "nombrecompromiso";
                txtnomcompr.ValueMember = "nombrecompromiso";

            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int valor = txtplazo.SelectedIndex;

            while (valor == 0)//mensual
            {
                if (txtnomcompr.Text == "" || txtplazo.Text == "" || txtfcaducidad.Text == "" || txtvalorcuota.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    Fechas Fechas = new Fechas();
                    Fechas.nomcompromiso = txtnomcompr.Text;
                    Fechas.plazo = txtplazo.Text;
                    Fechas.fdepago = txtfdeplazo.Value.ToString("yyyy-MM-dd");
                    Fechas.fcaducidad = txtfcaducidad.Value.ToString("yyyy-MM-dd");
                    Fechas.valordecuota = txtvalorcuota.Text;
                    Fechas.pago = txtpago.Text;
                    Fechas.formadepago = txtformapago.Text;
                    Fechas.cantidad = txtcantidad.Text;
                    int resultado = DALFechas.Agregarmensual(Fechas);



                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }

                    else
                    {
                        MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


                break;
            }
            while (valor == 1) //trimestral
            {
                if (txtnomcompr.Text == "" || txtplazo.Text == "" || txtfcaducidad.Text == "" || txtvalorcuota.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    Fechas Fechas = new Fechas();
                    Fechas.nomcompromiso = txtnomcompr.Text;
                    Fechas.plazo = txtplazo.Text;
                    Fechas.fdepago = txtfdeplazo.Value.ToString("yyyy-MM-dd");
                    Fechas.fcaducidad = txtfcaducidad.Value.ToString("yyyy-MM-dd");
                    Fechas.valordecuota = txtvalorcuota.Text;
                    Fechas.pago = txtpago.Text;
                    Fechas.formadepago = txtformapago.Text;
                    int resultado = DALFechas.AgregarTrimestral(Fechas);



                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }

                    else
                    {
                        MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


                break;
            }
            while (valor == 2) //Anual
            {
                if (txtnomcompr.Text == "" || txtplazo.Text == "" || txtfcaducidad.Text == "" || txtvalorcuota.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    Fechas Fechas = new Fechas();
                    Fechas.nomcompromiso = txtnomcompr.Text;
                    Fechas.plazo = txtplazo.Text;
                    Fechas.fdepago = txtfdeplazo.Value.ToString("yyyy-MM-dd");
                    Fechas.fcaducidad = txtfcaducidad.Value.ToString("yyyy-MM-dd");
                    Fechas.valordecuota = txtvalorcuota.Text;
                    Fechas.pago = txtpago.Text;
                    Fechas.formadepago = txtformapago.Text;
                    int resultado = DALFechas.AgregarAnual(Fechas);



                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }

                    else
                    {
                        MessageBox.Show("No se pudieron Guardar lo datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


                break;
            }
            
       }
           
    
        
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Fechas pFechas = new Fechas();
            pFechas.nomcompromiso = txtnomcompr.Text;
            pFechas.plazo = txtplazo.Text;
            pFechas.fdepago = txtfdeplazo.Value.ToString("yyyy-MM-dd");
            pFechas.fcaducidad = txtfcaducidad.Value.ToString("yyyy-MM-dd");
            pFechas.valordecuota = txtvalorcuota.Text;
            pFechas.pago = txtpago.Text;
            pFechas.formadepago = txtformapago.Text;
            pFechas.idcompromiso = FechaActual.idcompromiso;


            int resultado = DALFechas.Modificar(pFechas);

            if (resultado > 0)
            {

                MessageBox.Show("compromiso Modificado con exito", "compromiso Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true;
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el compromiso", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el compromiso??", "Esta seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int resultado = DALFechas.Eliminar(FechaActual.idcompromiso);

                if (resultado > 0)
                {

                    MessageBox.Show("Compromiso Eliminado Correctamente", "Compromiso Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnGuardar.Enabled = true;
                }

                else
                {
                    MessageBox.Show("No se pudo Eliminar el Compromiso", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Cancelado");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar pBuscar = new buscar();
            pBuscar.ShowDialog();

            if (pBuscar.FechasSeleccionado != null)
            {
                FechaActual = pBuscar.FechasSeleccionado;
                txtnomcompr.Text = pBuscar.FechasSeleccionado.nomcompromiso;
                if (String.IsNullOrEmpty(txtfdeplazo.Text = pBuscar.FechasSeleccionado.fdepago))
                        txtfdeplazo.CustomFormat = " ";
                else
                txtfdeplazo.Text = pBuscar.FechasSeleccionado.fdepago;
                txtplazo.Text = pBuscar.FechasSeleccionado.plazo;   
                txtfcaducidad.Text = pBuscar.FechasSeleccionado.fcaducidad;
                txtvalorcuota.Text = pBuscar.FechasSeleccionado.valordecuota;
                txtpago.Text = pBuscar.FechasSeleccionado.pago;
                txtformapago.Text = pBuscar.FechasSeleccionado.formadepago;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void txtfdeplazo_ValueChanged(object sender, EventArgs e)
        {
            txtfdeplazo.CustomFormat = "dd-MM-yyyy";
        }

        public void txtfcaducidad_ValueChanged(object sender, EventArgs e)
        {
            txtfcaducidad.CustomFormat = "dd-MM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();        
        }

        private void btnfvacia_Click(object sender, EventArgs e)
        {

        }

        private void txtplazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtformapago_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            // se define el valor del combobox selecionando desde el index que empieza 
            //desde el 0 este valor se compara para verificar la fecha 
            int valor = txtplazo.SelectedIndex;
            DateTime date1 = txtfcaducidad.Value;
            DateTime datemes = date1.AddMonths(1);
            DateTime datetrimestral = date1.AddMonths(3);
            DateTime dateanual = date1.AddYears(1);
            DateTime date2 = DateTime.Now;
            int result = DateTime.Compare(date1, date2);
            TimeSpan ts1 = date2 - date1;
            TimeSpan ts2 = date2 - datemes;
            TimeSpan ts3 = dateanual - date1;


            // diferencia en dias
            int differenceInDays = ts1.Days;
            string elabven = "";
            while (valor == 0) 
            {
                //mensual
             
                if (Convert.ToInt32(ts1.Days) > 0)
                {
                    elabven = Convert.ToString(ts1.Days);
                }
                else
                {
                    elabven = "VENCIDO!! " + ts1.Days;
                }

                MessageBox.Show("Vence el día: " + date1 + "   Estado  " + elabven + "  días");
                    
                   // MessageBox.Show("mensual");

                    //if (string.IsNullOrWhiteSpace(txtfdeplazo.Text))
                    //{
       
                    //    MessageBox.Show(" no ha pagado este compromiso " );
                    //}
                    //else if (date1 < date2)
                 
                    //    MessageBox.Show(" es anterior a la fecha antual ");
                    //else if(date1 == date2)
                    //    MessageBox.Show("es el mismo tiempo que");
                    //else
                      
                    //    MessageBox.Show("es posterior a la fecha actual");

                break;
            }

            while (valor == 1) 
            {
                //trimestral
               

                    date1.AddMonths(3);
                    MessageBox.Show("trimestral");

                    //if (string.IsNullOrWhiteSpace(txtfdeplazo.Text))
                    //{
                    //    MessageBox.Show(" no ha pagado este compromiso ");
                    //}
                    if (datetrimestral < date2)
                        MessageBox.Show("es anterior a " + differenceInDays + " dias");
                    else if (date1 == date2)
                        MessageBox.Show("es el mismo tiempo que");
                    else
                        MessageBox.Show("es posterior a " + differenceInDays + " dias");
                break;
            }

            while (valor == 2) 
            {
                //anual
               
                    date1.AddYears(1);
                    MessageBox.Show("anual");

                    if (string.IsNullOrWhiteSpace(txtfdeplazo.Text))
                    {
                        MessageBox.Show(" no ha pagado este compromiso ");
                    }
                    else if (date1 < date2)
                        MessageBox.Show("es anterior a " + differenceInDays + " dias");
                    else if (date1 == date2)
                        MessageBox.Show("es el mismo tiempo que");
                    else
                        MessageBox.Show("es posterior a");
                
                break;
            } 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inpagos ipagos = new inpagos();
            ipagos.ShowDialog();
        }

        private void impdatos_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MenuHome menu = new MenuHome();
            menu.Visible = true;
            Visible = false;
        }



        private void txtvalorcuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        private void txtnomcompr_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public int cantidad { get; set; }
    }
}

