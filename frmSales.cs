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
    public partial class frmSales : Form
    {
        DataSet ds;
        public frmSales()
        {
            InitializeComponent();

            actualizarTabla();
            actualizarComboBox();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE sales SET " +
                    "ord_num = '" + txtOrderNumber.Text + "', " +
                    "ord_date = '" + dtpOrder_Date.Text + "', " +
                    "qty = '" + numQuantity.Text + "', " +
                    "payterms = '" + txtPayterms.Text + "', " +
                    "title_id = '" + cmbTitle_ID.Text + "' " +

                    "' WHERE stor_id = '" + cmbStores_ID.Text + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Sales");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Sales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO sales( stor_id, ord_num, ord_date, qty, payterms, title_id) " +
                    "VALUES ('" + cmbStores_ID.Text + "','" +
                    txtOrderNumber.Text + "','" +
                    dtpOrder_Date.Text + "','" +
                    numQuantity.Text + "',' " +
                    txtPayterms.Text + "','" +
                    cmbTitle_ID.Text +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Sales", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema Sales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbStores_ID.Text = "";
            txtOrderNumber.Text = "";
            dtpOrder_Date.Text = "";
            numQuantity.Text = "";
            txtPayterms.Text = "";
            cmbTitle_ID.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + cmbStores_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM stores WHERE title_id = '" + cmbStores_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + cmbStores_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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
                MessageBox.Show(ex.Message, "Error tabla Sales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM sales WHERE " + cmb_SearchBy.Text + " = '" + txt_Buscar.Text + "'");


            if (ds != null)
            {
                dgvSales.DataSource = ds.Tables[0];
            }
        }

        private void btn_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT stor_id AS 'Stores ID', ord_num AS 'Order Number', ord_date AS 'Orders Date', qty AS 'Quantity', payterms  AS 'Payterms', title_id AS 'Titles ID' " +
                " FROM sales ");

            if (ds != null)
            {
                dgvSales.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        public void actualizarComboBox()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'sales'");
            cmb_SearchBy.DataSource = ds.Tables[0];
            cmb_SearchBy.DisplayMember = "COLUMN_NAME";
            cmb_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT stor_id FROM stores");
            cmbStores_ID.DataSource = ds.Tables[0];
            cmbStores_ID.DisplayMember = "stor_id";

            ds = dt.consulta("SELECT title_id FROM titles");
            cmbTitle_ID.DataSource = ds.Tables[0];
            cmbTitle_ID.DisplayMember = "title_id";
        } 
    } // end class
} // end namespace
