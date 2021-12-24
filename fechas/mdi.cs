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
    public partial class mdi : Form
    {
        //Guardo el usuario que inicio sesion
        public string UsuarioLogueado = "";
        public inicioseccion frmLogin;
        public MenuHome frmPrincipal;
        public mdi()
        {
            InitializeComponent();
        }

        public void AbrirFormularioPrincipal()
        {
            //this.frmPrincipal = new MenuHome();
            this.frmPrincipal.MdiParent = this;
            this.frmPrincipal.Show();
        }

        public void AbrirLogin()
        {
            this.frmLogin = new inicioseccion();
            this.frmLogin.MdiParent = this;//Asigno el formulario actual como su MDI parent
            this.frmLogin.Show();
        }

        public void CerrarSesion()
        {
            //Solo limpio los datos del usuario
            this.UsuarioLogueado = "";
            //Muestro el login
            AbrirLogin();
        }
        private void MDI_Load(object sender, EventArgs e)
        {
            //Si no hay ningun usuairo logueado muestro el login
            if (UsuarioLogueado.Trim().Length == 0)
            {
                AbrirLogin();
            }
        }

        private void mdi_Load_1(object sender, EventArgs e)
        {

        }

    }
}
