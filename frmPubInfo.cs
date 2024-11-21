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
    public partial class frmPubInfo : Form
    {
        Datos dt = new Datos();
        DataSet ds = new DataSet();

        string connectionString = @"Data Source = localhost; Integrated Security = true; initial catalog = pubs";
        public frmPubInfo()
        {
            InitializeComponent();
        }

        public void cargarCombo()
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string consulta = "SELECT pub_id FROM publishers WHERE pub_id NOT IN(SELECT pub_id FROM pub_info)";
                SqlCommand cmd = new SqlCommand(consulta, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbPubId.Items.Add(reader["pub_id"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: {ex.Message}", "Error - Pub Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void cargarDgv()
        {
            ds = dt.consulta("SELECT * FROM pub_info");
            dgvPubInfo.DataSource = ds.Tables[0];
        }

        private void frmPubInfo_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarDgv();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPubInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvPubInfo.Rows[e.RowIndex];

                int pub_id = Convert.ToInt32(dgvPubInfo.Rows[e.RowIndex].Cells["pub_id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string consulta = "SELECT logo FROM pub_info WHERE pub_id = @pub_id";

                    using (SqlCommand cmd = new SqlCommand(consulta, conn)) 
                    {
                        cmd.Parameters.AddWithValue("@pub_id", pub_id);

                        conn.Open();
                        byte[] imageData = (byte[])cmd.ExecuteScalar();
                        conn.Close();

                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox.Image = Image.FromStream(ms);
                            }
                        }
                    }

                }
                
            }
        }
    }
}
