using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmPrincipal : Form
    {

        // Atributos
        DataSet ds;

        public frmPrincipal()
        {

            InitializeComponent();
            this.CenterToScreen();
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            // MessageBox.Show("Ancho = " + this.Size.Width.ToString() + "\nAltura = " + this.Size.Height);
        } // end constructor default

        public frmPrincipal(string usuario)
        {
            InitializeComponent();
            this.CenterToScreen();
            labUsuario.Text = "Usuario: " + usuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTitles_Resetear_Click(object sender, EventArgs e)
        {
            //actualizarTabla("titles");
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthors frmAuthors = new frmAuthors();
            frmAuthors.Show();
        }

        private void publicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishers frmPublishers = new frmPublishers();
            frmPublishers.Show();
        }

        private void titlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitles frmTitles = new frmTitles();
            frmTitles.Show();
        }

        private void titleAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitle_Author frmTitleAuthor = new frmTitle_Author();
            frmTitleAuthor.Show();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStores frmStores = new frmStores();
            frmStores.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales frmSales = new frmSales();
            frmSales.Show();
        }

        private void royschedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoysched frmRoysched = new frmRoysched();
            frmRoysched.Show();
        }

        private void discountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscounts frmDiscounts = new frmDiscounts();
            frmDiscounts.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJobs frmJobs = new frmJobs();
            frmJobs.Show();
        }

        private void pubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPubInfo frmPubInfo = new frmPubInfo();
            frmPubInfo.Show();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.Show(); 
        }
    } // end class frmPrincipal
} // end namespace