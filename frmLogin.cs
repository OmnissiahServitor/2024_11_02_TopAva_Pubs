using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "ADMIN";
            this.CenterToScreen();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acceso a usuario " + txtUsuario.Text, "Acceso concedido",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            frmPrincipal frmPrincipal = new frmPrincipal(txtUsuario.Text);
            frmPrincipal.Show();
            this.Hide();
        }
    }
}
