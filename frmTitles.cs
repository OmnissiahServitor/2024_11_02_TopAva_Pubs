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
    public partial class frmTitles : Form
    {
        DataSet ds;

        public frmTitles()
        {
            InitializeComponent();
            actualizarTabla();

            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'titles'");
            cmbTitles_SearchBy.DataSource = ds.Tables[0];
            cmbTitles_SearchBy.DisplayMember = "COLUMN_NAME";
            cmbTitles_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT pub_id FROM publishers");
            cmbTitles_publisherID.DataSource = ds.Tables[0];
            cmbTitles_publisherID.DisplayMember = "pub_id";
        }
            

        private void btnTitles_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE titles SET " +
                    "title = '" + txtTitle_name.Text + "', " +
                    "type = '" + txtTitle_Type.Text + "', " +
                    "pub_id = '" + cmbTitles_publisherID.Text + "', " +
                    "price = '" + txtTitle_Price.Text + "', " +
                    "advance = '" + txtTitle_Advance.Text + "', " +
                    "royalty = '" + txtTitle_Royalty.Text + "', " +
                    "ytd_sales = '" + txtTitle_Sales.Text + "', " +
                    "notes = '" + rtxtTitles_Notes.Text + "', " +
                    "pubdate = '" + dtpTitles_Date.Text +

                    "' WHERE title_id = '" + mskTitle_ID.Text + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Titles");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Titles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTitles_Guardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO titles( title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate) " +
                    "VALUES ('" + mskTitle_ID.Text + "','" +
                    txtTitle_name.Text + "','" +
                    txtTitle_Type.Text + "','" +
                    cmbTitles_publisherID.Text + "','" +
                    txtTitle_Price.Text + "','" +
                    txtTitle_Advance.Text + "','" +
                    txtTitle_Royalty.Text + "','" +
                    txtTitle_Sales.Text + "','" +
                    rtxtTitles_Notes.Text + "','" +
                    dtpTitles_Date.Text +
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

        private void btnTitles_Limpiar_Click(object sender, EventArgs e)
        {
            mskTitle_ID.Text = "";
            txtTitle_name.Text = "";
            txtTitle_Type.Text = "";
            cmbTitles_publisherID.Text = "";
            txtTitle_Price.Text = "";

            txtTitle_Advance.Text = "";
            txtTitle_Royalty.Text = "";
            txtTitle_Sales.Text = "";
            rtxtTitles_Notes.Text = "";
            dtpTitles_Date.Text = "";
        }

        private void btnTitles_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskTitle_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM titles WHERE title_id = '" + mskTitle_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskTitle_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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

        private void btnTitles_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM titles WHERE " + cmbTitles_SearchBy.Text + " = '" + txtTitles_Buscar.Text + "'");

            if (ds != null)
            {
                dgvTitles.DataSource = ds.Tables[0];
            }
        }

        private void btnTitles_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT title_id AS 'ID', title AS 'Title', type AS 'Type', pub_id AS 'Pubs ID', price AS 'Price', advance AS 'Advance', royalty AS 'Royalty', ytd_sales AS 'Year-to-date Sales', notes AS 'Notes', pubdate AS 'Publications Date'" +
                " FROM titles ");

            if (ds != null)
            {
                dgvTitles.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()
    }
}
