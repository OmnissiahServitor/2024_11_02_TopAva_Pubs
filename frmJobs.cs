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
    public partial class frmJobs : Form
    {
        Datos dt = new Datos();
        DataSet ds = new DataSet();
        public frmJobs()
        {
            InitializeComponent();



            actualizardgv();

            numMinLvl.Minimum = 0;
            numMinLvl.Maximum = 1000;

            numMaxLvl.Minimum = 0;
            numMaxLvl.Maximum = 1000;

        }



        public void actualizardgv()
        {
            ds = dt.consulta("SELECT * FROM JOBS");

            if (ds != null)
            {
                dgvJobs.DataSource = ds.Tables[0];
            }
        }


        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string jobDesc = txtJobDesc.Text;
                int minLvl = (int)numMinLvl.Value;
                int maxLvl = (int)numMaxLvl.Value;
                string connectionString = @"Data Source = localhost; Integrated Security = true; initial catalog = pubs";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    SqlCommand command = new SqlCommand("spInsertarJob", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@job_desc", jobDesc);
                    command.Parameters.AddWithValue("@min_lvl", minLvl);
                    command.Parameters.AddWithValue("@max_lvl", maxLvl);
                    connection.Open(); command.ExecuteNonQuery(); connection.Close();

                    actualizardgv();
                }

                MessageBox.Show("Datos Agregados correctamente.", "Sistema Jobs", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "Sistema - Jobs", MessageBoxButtons.OK);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int selectedIndex = dgvJobs.SelectedRows[0].Index;
            int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["job_id"].Value);
            DialogResult result = MessageBox.Show("¿Está seguro de que quiere eliminar esta fila?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (result == DialogResult.Yes)
                {

                    string connectionString = @"Data Source = localhost; Integrated Security = true; initial catalog = pubs";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("spEliminarJob", connection);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@job_id", jobId);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Eliminación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        actualizardgv();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count > 0)
            {
                int jobId = Convert.ToInt32(dgvJobs.SelectedRows[0].Cells["job_id"].Value);
                string jobDesc = txtJobDesc.Text;
                int minLvl = (int)numMinLvl.Value;
                int maxLvl = (int)numMaxLvl.Value;
                string connectionString = "YourConnectionStringHere";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("spActualizarJob", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@job_id", jobId);
                    command.Parameters.AddWithValue("@job_desc", jobDesc);
                    command.Parameters.AddWithValue("@min_lvl", minLvl);
                    command.Parameters.AddWithValue("@max_lvl", maxLvl);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Modificación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizardgv();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                // Extraer los valores de las celdas y asignarlos a los controles del formulario
                txtJobDesc.Text = row.Cells["job_desc"].Value.ToString();
                numMinLvl.Value = Convert.ToInt32(row.Cells["min_lvl"].Value);
                numMaxLvl.Value = Convert.ToInt32(row.Cells["max_lvl"].Value);
            }
        }

        private void dgvJobs_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                // Extraer los valores de las celdas y asignarlos a los controles del formulario
                txtJobDesc.Text = row.Cells["job_desc"].Value.ToString();
                numMinLvl.Value = Convert.ToInt32(row.Cells["min_lvl"].Value);
                numMaxLvl.Value = Convert.ToInt32(row.Cells["max_lvl"].Value);


            }
        }

        private void dgvJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvJobs.Rows[e.RowIndex];

                // Extraer los valores de las celdas y asignarlos a los controles del formulario
                txtJobDesc.Text = row.Cells["job_desc"].Value.ToString();
                numMinLvl.Value = Convert.ToInt32(row.Cells["min_lvl"].Value);
                numMaxLvl.Value = Convert.ToInt32(row.Cells["max_lvl"].Value);


            }
        }
    }
}

       

