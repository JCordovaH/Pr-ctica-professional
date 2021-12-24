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
  
    public partial class MenuHome : Form
    {
        public MenuHome()
        {
            InitializeComponent(); 
        }

        public  string varf1;
        public  string varf2;
        public  string varf3;
        
        public void button1_Click(object sender, EventArgs e)
        {
            Registrocompromiso regiscompromiso = new Registrocompromiso();
            regiscompromiso.Visible = true;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            infocompromiso infocompromiso = new infocompromiso();
            infocompromiso.Visible = true;
           
        }

        public void MenuHome_Load(object sender, EventArgs e)
        {
            //    inicioseccion nomusu = new inicioseccion();
            //nomusu.pasado+= new inicioseccion.pasar(ejecutar);
          
                lbuserr.Text = varf1;
                lbfecha.Text = varf2;
                lbhora.Text = varf3;
                //lbtestusu.Text = lbuserr.Text;
        }
        //public void ejecutar(string dato)
        //{
        //    lbuserr.Text = dato; 
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //Cierro la sesion desde el MDI PARENT
            ((mdi)this.MdiParent).CerrarSesion();
            //Cierro el formulario actual
            this.Close();
        }
    }
}
