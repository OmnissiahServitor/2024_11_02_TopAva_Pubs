using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmTitle_Author : Form
    {
        DataSet ds;
        public frmTitle_Author()
        {
            InitializeComponent();
            actualizarTabla();

            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'titleauthor'");
            cmbTiAu_SearchBy.DataSource = ds.Tables[0];
            cmbTiAu_SearchBy.DisplayMember = "COLUMN_NAME";
            cmbTiAu_SearchBy.ValueMember = "ORDINAL_POSITION";

            actualizarComboBox();
        }

        private void btnTiAuModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE titleauthor SET " +
                    "au_id = '" + cmbAuTit_AuthorID.Text + "', " +
                    "au_ord = '" + txtAutTi_AuthorOrd.Text + "', " +
                    "royaltyper = '" + numTiAu_RoyaltyPercentage.Text + "' " +
                    
                    "' WHERE title_id = '" + cmbAuTit_TitleID.Text + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Title - Author");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Title - Author", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiAuGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO titleauthor( title_id, au_id, au_ord, royaltyper) " +
                    "VALUES ('" + cmbAuTit_TitleID.Text + "','" +
                    cmbAuTit_AuthorID.Text + "','" +
                    txtAutTi_AuthorOrd.Text + "','" +
                    numTiAu_RoyaltyPercentage.Text  +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Titles", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema tabla Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTiAuLimpiar_Click(object sender, EventArgs e)
        {
            cmbAuTit_TitleID.Text = "";
            cmbAuTit_AuthorID.Text = "";
            txtAutTi_AuthorOrd.Text = "";
            numTiAu_RoyaltyPercentage.Text = "0";
        }

        private void btnTiAuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + cmbAuTit_TitleID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM titleauthor WHERE title_id = '" + cmbAuTit_TitleID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + cmbAuTit_TitleID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
                        actualizarTabla();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error tabla Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTiAu_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM titleauthor WHERE " + cmbTiAu_SearchBy.Text + " = '" + txtTiAu_Buscar.Text + "'");


            if (ds != null)
            {
                dgvTitleAuthor.DataSource = ds.Tables[0];
            }
        }

        private void btnTiAu_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT au_id AS 'Authors ID', title_id AS 'Titles ID', au_ord AS 'Author order', royaltyper AS 'Royalty Percentage'" +
                " FROM titleauthor ");

            if (ds != null)
            {
                dgvTitleAuthor.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        public void actualizarComboBox()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT title_id FROM titles");
            cmbAuTit_TitleID.DataSource = ds.Tables[0];
            cmbAuTit_TitleID.DisplayMember = "title_id";
            //cmbTiAu_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT au_id FROM authors");
            cmbAuTit_AuthorID.DataSource = ds.Tables[0];
            cmbAuTit_AuthorID.DisplayMember = "au_id";
        }
    } // end class
} // end namespace
