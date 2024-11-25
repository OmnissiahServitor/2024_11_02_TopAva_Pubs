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
        string connectionString = @"Data Source = localhost; Integrated Security = true; initial catalog = pubs";

        public frmDiscounts()
        {
            InitializeComponent();
            num_LowQuantity.Minimum = 0;
            num_LowQuantity.Maximum = 100000;
            num_HighQuantity.Minimum = 0;
            num_HighQuantity.Maximum = 100000;

            actualizarTabla();
            actualizarComboBox();
        }

        private void limpiar() 
        {
            txtType.Text = "";
            cmbStore_ID.Text = "";
            num_LowQuantity.Value = 0;
            num_HighQuantity.Value = 0;
            txt_DiscountPer.Text = "0.0";
        }

        private void btnModificar_Click(object sender, EventArgs e)//Aqui falta
        {
            try
            {

                if (MessageBox.Show("Esta seguro que quiere modificar los datos?", "Sistema - Discounts", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    if (dgvDiscounts.SelectedRows.Count > 0)
                    {
                       string discounttype = txtType.Text;
                       string store_id = cmbStore_ID.Text;
                        int lowqty = (int)num_LowQuantity.Value;
                        int highqty = (int)num_HighQuantity.Value;
                        
                        double discount = Convert.ToDouble(txt_DiscountPer.Text); 

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string consulta = "UPDATE discounts SET discounttype = @discounttype, stor_id = @stor_id, lowqty = @lowqty, highqty = @highqty, discount = @discount WHERE discounttype = @discounttype or discount = @discount";
                            using (SqlCommand cmd = new SqlCommand(consulta, conn))
                            {
                                cmd.Parameters.AddWithValue("@discounttype", discounttype);
                                cmd.Parameters.AddWithValue("@stor_id", store_id);
                                cmd.Parameters.AddWithValue("@lowqty", lowqty);
                                cmd.Parameters.AddWithValue("@highqty", highqty);
                                cmd.Parameters.AddWithValue("@discount", discount);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                        MessageBox.Show("Datos modificados con exito", "Sistema - Discounts", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        actualizarTabla();
                        limpiar();

                    }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Ha ocurrido un error" + ex.ToString(), "Sistema - Discounts", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtType.Text = "";
            cmbStore_ID.Text = "";
            num_LowQuantity.Value = 0;
            num_HighQuantity.Value = 0;
            txt_DiscountPer.Text = "0.0";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar los datos?", "Sistema - Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (dgvDiscounts.Rows.Count > 0)
                {
                    string disctype = dgvDiscounts.SelectedRows[0].Cells["discounttype"].Value.ToString();
                    decimal discount = Convert.ToDecimal(dgvDiscounts.SelectedRows[0].Cells["discount"].Value.ToString());

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string consulta = "DELETE FROM discounts WHERE discounttype = @discounttype and discount = @discount";
                        using (SqlCommand cmd = new SqlCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@discounttype", disctype);
                            cmd.Parameters.AddWithValue("@discount", discount);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                    }
                    limpiar();
                    actualizarTabla();
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
            ds = dt.consulta("SELECT * FROM discounts");
            dgvDiscounts.DataSource = ds.Tables[0];
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

        private void dgvDiscounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpiar();
                if (e.RowIndex >= 0)
                {

                    txtType.Text = dgvDiscounts.Rows[e.RowIndex].Cells["discounttype"].Value.ToString();
                    cmbStore_ID.Text = dgvDiscounts.Rows[e.RowIndex].Cells["stor_id"].Value.ToString();
                    num_LowQuantity.Value = Convert.ToInt32(dgvDiscounts.Rows[e.RowIndex].Cells["lowqty"].Value.ToString());
                    num_HighQuantity.Value = Convert.ToInt32(dgvDiscounts.Rows[e.RowIndex].Cells["highqty"].Value.ToString());
                    txt_DiscountPer.Text = dgvDiscounts.Rows[e.RowIndex].Cells["discount"].Value.ToString();
                }
            }
            catch (System.FormatException)
            {

            }
        }

        private void dgvDiscounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDiscounts.Rows[e.RowIndex];


                txtDiscount_ID.Text = selectedRow.Cells[0].Value.ToString();
                txtType.Text = selectedRow.Cells[1].Value.ToString();
                cmbStore_ID.Text = selectedRow.Cells[2].Value.ToString();
                num_LowQuantity.Value = int.Parse(selectedRow.Cells[3].Value.ToString() );
                num_HighQuantity.Value = int.Parse(selectedRow.Cells[4].Value.ToString() );
                txt_DiscountPer.Text = selectedRow.Cells[5].Value.ToString();
            }
        }
    } // end class
} // end namespace
