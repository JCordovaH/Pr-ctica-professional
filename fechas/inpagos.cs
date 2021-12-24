using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fechas
{
    public partial class inpagos : Form
    {
        public inpagos()
        {
            InitializeComponent();
        }
        void limpiar()
        {
            lbcompromiso.Text = "";
            txtinplazo.SelectedIndex = -1;
            txtfpago.CustomFormat = " ";
            txtfdecaducidad.CustomFormat = " ";
            lbcuota.Text = "";
            txtinpago.Clear();
            txtforpago.SelectedIndex = -1;

        }
        public Fechas FechaActual { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            buscar pBuscar = new buscar();
            pBuscar.ShowDialog();

            if (pBuscar.FechasSeleccionado != null)
            {
                FechaActual = pBuscar.FechasSeleccionado;
                lbcompromiso.Text = pBuscar.FechasSeleccionado.nomcompromiso;
                if (String.IsNullOrEmpty(txtfpago.Text = pBuscar.FechasSeleccionado.fdepago))
                    txtfpago.CustomFormat = " ";
                else
                    txtfpago.Text = pBuscar.FechasSeleccionado.fdepago;
                txtinplazo.Text = pBuscar.FechasSeleccionado.plazo;
                txtfdecaducidad.Text = pBuscar.FechasSeleccionado.fcaducidad;
                lbcuota.Text = pBuscar.FechasSeleccionado.valordecuota;
                txtinpago.Text = pBuscar.FechasSeleccionado.pago;
                txtforpago.Text = pBuscar.FechasSeleccionado.formadepago;

             
              
            }
        }

        private void inpagos_Load(object sender, EventArgs e)
        {
            this.txtforpago.Items.Add("Factura");
            this.txtforpago.Items.Add("Boleta");


            txtinplazo.Items.Insert(0, "Mensual");
            txtinplazo.Items.Insert(1, "Trimestal");
            txtinplazo.Items.Insert(2, "Anual");
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            Fechas pFechas = new Fechas();
            pFechas.nomcompromiso = lbcompromiso.Text;
            pFechas.plazo = txtinplazo.Text;
            pFechas.fdepago = txtfpago.Value.ToString("yyyy-MM-dd");
            pFechas.fcaducidad = txtfdecaducidad.Value.ToString("yyyy-MM-dd");
            pFechas.valordecuota = lbcuota.Text;
            pFechas.pago = txtinpago.Text;
            pFechas.formadepago = txtforpago.Text;
            pFechas.idcompromiso = FechaActual.idcompromiso;


            int resultado = DALFechas.Modificar(pFechas);

            if (resultado > 0)
            {

                MessageBox.Show("compromiso Modificado con exito", "compromiso Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
             
            }

            else
            {
                MessageBox.Show("No se pudo Modificar el compromiso", "Ocurrio un error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuHome menu = new MenuHome();
            menu.Visible = true;
            Visible = false;
        }
    }
}
