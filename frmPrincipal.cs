using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmPrincipal : Form
    {

        // Atributos
        DataSet ds;

        public frmPrincipal()
        {

            InitializeComponent();
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            // MessageBox.Show("Ancho = " + this.Size.Width.ToString() + "\nAltura = " + this.Size.Height);
        } // end constructor default

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM authors ");

            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT* FROM publishers");
                dgvPublishers.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM titles");
                dgvTitles.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM titleauthor");
                dgvTitleAuthor.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM stores");
                dgvStores.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM sales");
                dgvSales.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM roysched");
                dgvRoysched.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM discounts");
                dgvDiscounts.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM jobs ");
                dgvJobs.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM pub_info");
                dgvPubInfo.DataSource = ds.Tables[0];

                ds = dt.consulta("SELECT * FROM employee");
                dgvEmployee.DataSource = ds.Tables[0];

            } // end if ds != null


        } // end frmPrincipal_Load() 

       
    } // end class frmPrincipal
} // end namespace