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
    public partial class frmDiscounts : Form
    {
        DataSet ds;
        public frmDiscounts()
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
                bool j = dt.ejecutarABC("WITH numbered_rows AS ( " +
                    "SELECT stor_id, ROW_NUMBER() OVER (ORDER BY title_id) AS row_num " +
                    "FROM discounts) " +
                    "UPDATE discounts " +
                    "SET discounttype = '" + txtType.Text + "', " +
                    "stor_id = '" + cmbStore_ID.Text + "', " +
                    "lowqty = '" + num_LowQuantity.Value.ToString() + "', " +
                    "highqty = '" + num_HighQuantity.Value.ToString() + "', " +
                    "discount = '" + txt_DiscountPer.Text + "' " +
                    "WHERE stor_id = (SELECT stor_id FROM numbered_rows WHERE row_num = '" + txtDiscount_ID.Text + "')"
                    );

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Roysched");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Discounts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO discounts( discounttype, stor_id, lowqty, highqty, discount) " +
                    "VALUES ('" + txtType.Text + "','" +
                    cmbStore_ID.Text + "','" +
                    num_LowQuantity.Text + "','" +
                    num_HighQuantity.Text + "',' " +
                    txt_DiscountPer.Text +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Roysched", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema Discounts", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDiscount_ID.Text = "";
            txtType.Text = "";
            cmbStore_ID.Text = "";
            num_LowQuantity.Value = 0;
            num_HighQuantity.Value = 0;
            txt_DiscountPer.Text = "0.0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + txtDiscount_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    if (dgvDiscounts.SelectedRows.Count > 0)
                    {
                        int id = Convert.ToInt32(dgvDiscounts.SelectedRows[0].Cells["Discounts ID"]);

                        datos.ejecutarABC("DELETE FROM discounts where ");
                    }
                    bool j = datos.ejecutarABC("DELETE FROM discounts where ");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + txtDiscount_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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
                MessageBox.Show(ex.Message, "Error tabla Stores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM discounts WHERE " + cmb_SearchBy.Text + " = '" + txt_Buscar.Text + "'");


            if (ds != null)
            {
                dgvDiscounts.DataSource = ds.Tables[0];
            }
        }

        private void btn_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT ROW_NUMBER() OVER (ORDER BY discountType) AS 'Discounts ID', discounttype AS 'Discount Type', stor_id AS 'Store ID', lowqty AS 'Low Quantity', highqty AS 'High Quantity', discount AS 'Discount'"
                    + " FROM discounts ");

            if (ds != null)
            {
                dgvDiscounts.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        public void actualizarComboBox()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'discounts'");
            cmb_SearchBy.DataSource = ds.Tables[0];
            cmb_SearchBy.DisplayMember = "COLUMN_NAME";
            cmb_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT stor_id FROM stores");
            cmbStore_ID.DataSource = ds.Tables[0];
            cmbStore_ID.DisplayMember = "stor_id";
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_SearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // end class
} // end namespace
