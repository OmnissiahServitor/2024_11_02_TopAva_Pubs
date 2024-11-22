using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmEmployee : Form
    {
        DataSet ds = new DataSet();
        Datos dt = new Datos();

        string connectionString = @"Data Source = localhost; Integrated Security = true; initial catalog = pubs";
        public frmEmployee()
        {
            InitializeComponent();

            dtEmployee.Format = DateTimePickerFormat.Custom;
            dtEmployee.CustomFormat = "yyyy-MM-dd";
            SetNumericUpDownValues();
        }
        public void cargarDgv()
        {
            ds = dt.consulta("SELECT * FROM employee");
            dgvEmployee.DataSource = ds.Tables[0];
        }

        private void SetNumericUpDownValues()
        {
            // Diccionario que mapea job_id a sus respectivos min_lvl y max_lvl
            var jobLevels = new Dictionary<int, (int min_lvl, int max_lvl)>
                {
                    { 1, (10, 10) },
                    { 2, (200, 250) },
                    { 3, (175, 225) },
                    { 4, (175, 250) },
                    { 5, (150, 250) },
                    { 6, (100, 175) },
                    { 7, (120, 200) },
                    { 8, (100, 175) },
                    { 9, (75, 165) },
                    { 10, (75, 165) },
                    { 11, (75, 165) },
                    { 12, (25, 100) },
                    { 13, (25, 100) },
                    { 14, (25, 100) },
                    { 15, (100, 100) },
                    { 16, (100, 100) }
                };

            // Obtener el job_id seleccionado en el ComboBox
            if (cmbJobId.SelectedItem != null && int.TryParse(cmbJobId.SelectedItem.ToString(), out int selectedJobId))
            {
                // Verificar si el job_id existe en el diccionario
                if (jobLevels.TryGetValue(selectedJobId, out var levels))
                {
                    // Asignar los valores min y max al NumericUpDown
                    nudJobLvl.Minimum = levels.min_lvl;
                    nudJobLvl.Maximum = levels.max_lvl;
                    nudJobLvl.Value = levels.min_lvl;

                    nudJobLvl.Minimum = levels.min_lvl;
                    nudJobLvl.Maximum = levels.max_lvl;
                    nudJobLvl.Value = levels.max_lvl;
                }
            }
        }

        public void limpiar()
        {
            txtEmployeeId.Text = "";
            txtFname.Text = "";
            txtMinit.Text = "";
            txtLastName.Text = "";
            cmbJobId.Text = "";

            cmbPubId.Text = "";
            dtEmployee.Value = DateTime.Now;
            cargarDgv();
        }

        public void cargarCombo()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string consulta = "SELECT pub_id FROM pub_info";
                string consulta2 = "SELECT job_id FROM jobs";

                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlCommand cmd2 = new SqlCommand(consulta2, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbPubId.Items.Add(reader["pub_id"].ToString());
                    }

                    reader.Close();

                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        cmbJobId.Items.Add(reader2["job_id"].ToString());
                    }
                    reader2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: {ex.Message}", "Error - Pub Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            cargarDgv();
            cargarCombo();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string employeeId = dgvEmployee.Rows[e.RowIndex].Cells["emp_id"].Value.ToString();
                    string fname = dgvEmployee.Rows[e.RowIndex].Cells["fname"].Value.ToString();
                    string minit = dgvEmployee.Rows[e.RowIndex].Cells["minit"].Value.ToString();
                    string lname = dgvEmployee.Rows[e.RowIndex].Cells["lname"].Value.ToString();
                    int jobId = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["job_id"].Value.ToString());
                    int joblvl = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["job_lvl"].Value.ToString());
                    int publisherId = Convert.ToInt32(dgvEmployee.Rows[e.RowIndex].Cells["pub_id"].Value.ToString());
                    DateTime hiredate = Convert.ToDateTime(dgvEmployee.Rows[e.RowIndex].Cells["hire_date"].Value);

                    txtEmployeeId.Text = employeeId;
                    txtFname.Text = fname;
                    txtMinit.Text = minit;
                    txtLastName.Text = lname;
                    cmbJobId.Text = jobId.ToString();
                    nudJobLvl.Value = joblvl;
                    cmbPubId.Text = publisherId.ToString();
                    dtEmployee.Value = hiredate;


                }
            }
            catch (System.FormatException)
            {

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "";
            txtFname.Text = "";
            txtMinit.Text = "";
            txtLastName.Text = "";
            cmbJobId.Text = "";
            nudJobLvl.Value = 0;
            cmbPubId.Text = "";
            dtEmployee.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
                string employeeId = txtEmployeeId.Text;
                string fname = txtFname.Text;
                string minit = txtMinit.Text;
                string lname = txtLastName.Text;
                int jobId = Convert.ToInt32(cmbJobId.Text);
                int joblvl = Convert.ToInt32(nudJobLvl.Value);
                int publisherId = Convert.ToInt32(cmbPubId.Text);
                DateTime hiredate = dtEmployee.Value;
           
                if (MessageBox.Show("Sus datos son correctos?", "Sistema - Pub_Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string consulta = "INSERT INTO employee(emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date)" +
                                "VALUES(@emp_id, @fname, @minit, @lname, @job_id, @job_lvl, @pub_id, @hire_date)";
                            using (SqlCommand cmd = new SqlCommand(consulta, conn))
                            {
                                cmd.Parameters.AddWithValue("@emp_id", employeeId);
                                cmd.Parameters.AddWithValue("@fname", fname);
                                cmd.Parameters.AddWithValue("@minit", minit);
                                cmd.Parameters.AddWithValue("@lname", lname);
                                cmd.Parameters.AddWithValue("@job_id", jobId);
                                cmd.Parameters.AddWithValue("@job_lvl", joblvl);
                                cmd.Parameters.AddWithValue("@pub_id", publisherId);
                                cmd.Parameters.AddWithValue("@hire_date", hiredate);


                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                            MessageBox.Show("Datos agregados correctamente", "Sistema - Pub_Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbPubId.Items.Clear();

                            cargarDgv();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Por favor, ingresa un EmployeeId valido", "Sistema - Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Para generar un EmployeeId valido usa [A-Z][A-Z][A-Z][1-9][0-9][0-9][0-9][0-9][F ó M]", "Sistema - Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                     
                }
           
            
        }

        private void cmbJobId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNumericUpDownValues();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar los datos?", "Sistema - Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (dgvEmployee.Rows.Count > 0)
                {
                    string employee_id = dgvEmployee.SelectedRows[0].Cells["emp_id"].Value.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string consulta = "DELETE FROM employee WHERE emp_id = @emp_id";
                        using (SqlCommand cmd = new SqlCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@emp_id", employee_id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    cmbPubId.Items.Clear();
                    limpiar();
                }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Esta seguro que quiere modificar los datos?", "Sistema - Pub_Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    if (dgvEmployee.SelectedRows.Count > 0)
                    {
                        string employeeId = txtEmployeeId.Text;
                        string fname = txtFname.Text;
                        string minit = txtMinit.Text;
                        string lname = txtLastName.Text;
                        int jobId = Convert.ToInt32(cmbJobId.Text);
                        int joblvl = Convert.ToInt32(nudJobLvl.Value);
                        int publisherId = Convert.ToInt32(cmbPubId.Text);
                        DateTime hiredate = dtEmployee.Value;
                        
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                string consulta = "UPDATE employee SET fname = @fname, minit = @minit, lname = @lname, job_id = @job_id, job_lvl = @job_lvl, pub_id = @pub_id, hire_date = @hire_date WHERE emp_id = @emp_id;";
                                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                                {
                                    if (minit.Length > 1) minit = minit.Substring(0, 1);
                                    cmd.Parameters.AddWithValue("@emp_id", employeeId);
                                    cmd.Parameters.AddWithValue("@fname", fname);
                                    cmd.Parameters.AddWithValue("@minit", minit);
                                    cmd.Parameters.AddWithValue("@lname", lname);
                                    cmd.Parameters.AddWithValue("@job_id", jobId);
                                    cmd.Parameters.AddWithValue("@job_lvl", joblvl);
                                    cmd.Parameters.AddWithValue("@pub_id", publisherId);
                                    cmd.Parameters.AddWithValue("@hire_date", hiredate);
                                    conn.Open();
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                            MessageBox.Show("Datos modificados con exito", "Sistema - Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbPubId.Items.Clear();
                        
                       
                        limpiar();

                    }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Por favor, ingresa un EmployeeId valido", "Sistema - Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Para generar un EmployeeId valido usa [A-Z][A-Z][A-Z][1-9][0-9][0-9][0-9][0-9][F ó M]", "Sistema - Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
