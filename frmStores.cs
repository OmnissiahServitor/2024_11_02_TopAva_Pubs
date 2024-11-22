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
    public partial class frmStores : Form
    {
        DataSet ds;

        public frmStores()
        {
            InitializeComponent();
            actualizarTabla();

            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'stores'");
            cmb_SearchBy.DataSource = ds.Tables[0];
            cmb_SearchBy.DisplayMember = "COLUMN_NAME";
            cmb_SearchBy.ValueMember = "ORDINAL_POSITION";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE stores SET " +
                    "stor_name = '" + txtStores_name.Text + "', " +
                    "stor_address = '" + txtStores_address.Text + "', " +
                    "city = '" + txtStores_City.Text + "', " +
                    "state = '" + mskStores_State.Text + "', " +
                    "zip = '" + mskStores_Zip.Text + "' " +

                    "' WHERE stor_id = '" + mskStores_ID.Text + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Stores");
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Stores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO stores( stor_id, stor_name, stor_address, city, state, zip) " +
                    "VALUES ('" + mskStores_ID.Text + "','" +
                    txtStores_name.Text + "','" +
                    txtStores_address.Text + "','" +
                    txtStores_City.Text + "',' " +
                    mskStores_State.Text + "','" +
                    mskStores_Zip.Text +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Stores", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema Stores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mskStores_ID.Text = "";
            txtStores_name.Text = "";
            txtStores_address.Text = "";
            txtStores_City.Text = "";
            mskStores_State.Text = "";
            mskStores_Zip.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskStores_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM stores WHERE title_id = '" + mskStores_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskStores_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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

            ds = dt.consulta("SELECT * FROM stores WHERE " + cmb_SearchBy.Text + " = '" + txt_Buscar.Text + "'");


            if (ds != null)
            {
                dgvStores.DataSource = ds.Tables[0];
            }
        }

        private void btn_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT stor_id AS 'ID', stor_name AS 'Name', stor_address AS 'Address', city AS 'City', state AS 'State', zip AS 'Zip' " +
                " FROM stores ");

            if (ds != null)
            {
                dgvStores.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        private void dgvStores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvStores.Rows[e.RowIndex];

                
                mskStores_ID.Text = selectedRow.Cells[0].Value.ToString(); ;
                txtStores_name.Text = selectedRow.Cells[1].Value.ToString(); ;
                txtStores_address.Text = selectedRow.Cells[2].Value.ToString(); ;
                txtStores_City.Text = selectedRow.Cells[3].Value.ToString(); ;
                mskStores_State.Text = selectedRow.Cells[4].Value.ToString(); ;
                mskStores_Zip.Text = selectedRow.Cells[5].Value.ToString(); ;
            }
        }
    } // end class
} // end namespace