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
    public partial class frmRoysched : Form
    {
        DataSet ds;
        public frmRoysched()
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
                    "SELECT title_id, ROW_NUMBER() OVER (ORDER BY title_id) AS row_num " +
                    "FROM roysched) " +
                    "UPDATE roysched " +
                    "SET title_id = '" + cmbTitle_ID.Text + "', " +
                    "lorange = '" + numLowRange.Value.ToString() + "', " +
                    "hirange = '" + numHigh_Range.Value.ToString() + "', " +
                    "royalty = '" + numRoyalty.Value.ToString() + "' " +
                    "WHERE title_id = (SELECT title_id FROM numbered_rows WHERE row_num = '" + txtRoysched_ID.Text + "')"
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
                MessageBox.Show(ex.Message, "Sistema - Roysched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO roysched( title_id, lorange, hirange, royalty) " +
                    "VALUES ('" + cmbTitle_ID.Text + "','" +
                    numLowRange.Text + "','" +
                    numHigh_Range.Text + "','" +
                    numRoyalty.Text +
                    "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema Roysched", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema Roysched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRoysched_ID.Text = "";
            cmbTitle_ID.Text = "";
            numLowRange.Value = 0;
            numHigh_Range.Value = 0;
            numRoyalty.Value = 0;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + txtRoysched_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("WITH numbered_rows AS ( " +
                        "SELECT title_id, ROW_NUMBER() OVER (ORDER BY title_id) AS row_num " +
                        "FROM roysched " +
                        ") " +
                        "DELETE FROM roysched " +
                        "WHERE title_id = (SELECT title_id FROM numbered_rows WHERE row_num = '" + txtRoysched_ID.Text + "' )");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + txtRoysched_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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
                MessageBox.Show(ex.Message, "Error tabla Roysched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM roysched WHERE " + cmb_SearchBy.Text + " = '" + txt_Buscar.Text + "'");


            if (ds != null)
            {
                dgvRoysched.DataSource = ds.Tables[0];
            }
        }

        private void btn_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT ROW_NUMBER() OVER (ORDER BY title_id) AS 'Royalty ID', title_id AS 'Title ID', lorange AS 'Low Range', hirange AS 'High Range', royalty AS 'Royalty'"
                    + " FROM roysched ");

            if (ds != null)
            {
                dgvRoysched.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        public void actualizarComboBox()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'roysched'");
            cmb_SearchBy.DataSource = ds.Tables[0];
            cmb_SearchBy.DisplayMember = "COLUMN_NAME";
            cmb_SearchBy.ValueMember = "ORDINAL_POSITION";

            ds = dt.consulta("SELECT title_id FROM titles");
            cmbTitle_ID.DataSource = ds.Tables[0];
            cmbTitle_ID.DisplayMember = "title_id";
        }

        private void dgvRoysched_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvRoysched.Rows[e.RowIndex];



                // Extraer los valores de las celdas y asignarlos a los controles del formulario

                txtRoysched_ID.Text = selectedRow.Cells[0].Value.ToString();
                cmbTitle_ID.Text = selectedRow.Cells[1].Value.ToString();
                numLowRange.Value = int.Parse(selectedRow.Cells[2].Value.ToString());
                numHigh_Range.Value = int.Parse(selectedRow.Cells[3].Value.ToString());
                numRoyalty.Value = int.Parse(selectedRow.Cells[4].Value.ToString());

                
            }
        }
    } // end class
} // end namespace
