using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace fechas
{
    public partial class impdatos : Form
    {

        public List<Fechas> datos = new List<Fechas>();
        public impdatos()
        {
            InitializeComponent();
        }

        private void impdatos_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datos));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        public void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
