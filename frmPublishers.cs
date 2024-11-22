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
    public partial class frmPublishers : Form
    {
        DataSet ds;
        public frmPublishers()
        {
            InitializeComponent();
            actualizarTabla();

            Datos dt = new Datos();

            ds = dt.consulta("SELECT ORDINAL_POSITION, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'publishers'");
            cmbPublishers_SearchBy.DataSource = ds.Tables[0];
            cmbPublishers_SearchBy.DisplayMember = "COLUMN_NAME";
            cmbPublishers_SearchBy.ValueMember = "ORDINAL_POSITION";
        }

        private void btnPublishersModificar_Click(object sender, EventArgs e)
        {
            string id = mskPublishers_ID.Text;

            try
            {
                Datos dt = new Datos();
                bool j = dt.ejecutarABC("UPDATE publishers SET " +
                    "pub_name = '" + txtPublisher_name.Text + "', " +
                    "city = '" + txtPublisher_City.Text + "', " +
                    "state = '" + mskPublisher_State.Text + "', " +
                    "country = '" + txtPublisher_Country.Text + "', " +
                    "' WHERE pub_id = '" + id + "'");

                if (j)
                {
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("No se pudo hacer la modificacion a la tabla", "Sistema - Publishers");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sistema - Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnPublishersModificar_Click

        private void btnPublishersGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los datos son correctos?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                Datos datos = new Datos();
                bool j = datos.ejecutarABC("INSERT INTO publishers( pub_id, pub_name, city, state, country) " +
                    "VALUES ('" + mskPublishers_ID.Text + "','" + txtPublisher_name.Text + "','" + txtPublisher_City.Text + "','" + mskPublisher_State.Text + "','" +
                    txtPublisher_Country.Text + "')");

                if (j == true)
                {
                    MessageBox.Show("Datos Agregados Correctamente", "Sistema", MessageBoxButtons.OK);
                    actualizarTabla();
                }
                else
                {
                    MessageBox.Show("Error", "Sistema tabla Publishers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // end if
        } // end btnPublishersGuardar_Click

        private void btnPublishersLimpiar_Click(object sender, EventArgs e)
        {
            mskPublishers_ID.Text = "";
            txtPublisher_name.Text = "";
            txtPublisher_City.Text = "";
            mskPublisher_State.Text = "";
            txtPublisher_Country.Text = "";
        } // end btnPublishersLimpiar_Click

        private void btnPublishersEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que deseas borrar el registro ID: " + mskPublishers_ID.Text + "?", "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Datos datos = new Datos();
                    bool j = datos.ejecutarABC("DELETE FROM publishers WHERE pub_id = '" + mskPublishers_ID.Text + "'");

                    if (j == true)
                    {
                        MessageBox.Show("ID: " + mskPublishers_ID.Text + " borrado del registro", "Sistema", MessageBoxButtons.OK);
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
        } // end btnPublishersEliminar_Click

        private void btnPublishers_Buscar_Click(object sender, EventArgs e)
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT * FROM publishers WHERE " + cmbPublishers_SearchBy.Text + " = '" + txtPublishers_Buscar.Text + "'");

            if (ds != null)
            {
                dgvPublishers.DataSource = ds.Tables[0];
            }
        } // end btnPublishers_Buscar_Click

        private void btnPublishers_Resetear_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        } // end btnPublishers_Resetear_Click

        public void actualizarTabla()
        {
            Datos dt = new Datos();

            ds = dt.consulta("SELECT pub_id AS 'ID', pub_name AS 'Publishers name', city AS 'City', state AS 'State', country AS 'Country'" +
                " FROM publishers ");

            if (ds != null)
            {
                dgvPublishers.DataSource = ds.Tables[0];
            } // end if ds!=null
        } // end actualizarTabla()

        private void dgvPublishers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvPublishers.Rows[e.RowIndex];

                // Extraer los valores de las celdas y asignarlos a los controles del formulario
                mskPublishers_ID.Text = selectedRow.Cells[0].Value.ToString();
                txtPublisher_name.Text = selectedRow.Cells[1].Value.ToString();
                txtPublisher_City.Text = selectedRow.Cells[2].Value.ToString();
                mskPublisher_State.Text = selectedRow.Cells[3].Value.ToString();
                txtPublisher_Country.Text = selectedRow.Cells[4].Value.ToString();

            }
        }
    } // end class publishers
} // end namespace
