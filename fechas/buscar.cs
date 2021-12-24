using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace fechas
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        public Fechas FechasSeleccionado { get; set; }
        public MySqlConnection cnn = new MySqlConnection("server = localhost; database=estadocuenta; Uid=root; pwd=ps123;");
        private void btbuscarr_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = DALFechas.BuscarFechas(txtnomcompr.Text, dtpfdesde.Value, dtpfhasta.Value);
            
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Int64 Id = Convert.ToInt64(dataGridView1.CurrentRow.Cells[0].Value);
                FechasSeleccionado = DALFechas.Obtenerfecha(Id);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun compromiso");
            }
        }
           
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnfvacio_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DALFechas.fdepagovacias(dtpfnulos.Text);

        }

        private void dtpfechas_ValueChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = DALFechas.BuscarFechas(txtnomcompr.Text);
        }

        private void buscar_Load(object sender, EventArgs e)
        {
      
        }

        private void fdesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            impdatos rep = new impdatos();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Fechas dat = new Fechas();
                dat.idcompromiso = (Int64)this.dataGridView1.Rows[i].Cells[0].Value;
                dat.nomcompromiso = (string)this.dataGridView1.Rows[i].Cells[1].Value;
                dat.plazo = (string)this.dataGridView1.Rows[i].Cells[2].Value;
                dat.fdepago = (string)this.dataGridView1.Rows[i].Cells[3].Value;
                dat.fcaducidad = (string)this.dataGridView1.Rows[i].Cells[4].Value;
                dat.valordecuota = (string)this.dataGridView1.Rows[i].Cells[5].Value;
                dat.pago = (string)this.dataGridView1.Rows[i].Cells[6].Value;
                dat.formadepago = (string)this.dataGridView1.Rows[i].Cells[7].Value;
                rep.datos.Add(dat);
            }
            rep.ShowDialog();
        }

        private void dtpfhasta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
