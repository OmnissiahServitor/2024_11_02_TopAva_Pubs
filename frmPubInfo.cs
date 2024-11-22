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
        OpenFileDialog ofd = new OpenFileDialog();

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

        public void limpiar()
        {
            cmbPubId.Text = "";
            txtPrInfo.Text = "";
            pictureBox.Image = null;
            cargarDgv();
            cargarCombo();
        }

        public void cargarDgv()
        {
            ds = dt.consulta("SELECT pub_id, pr_info FROM pub_info");
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvPubInfo.Rows[e.RowIndex];

                    int pub_id = Convert.ToInt32(dgvPubInfo.Rows[e.RowIndex].Cells["pub_id"].Value);
                    string pr_info = dgvPubInfo.Rows[e.RowIndex].Cells["pr_info"].Value.ToString();

                    txtPrInfo.Text = pr_info;

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
            catch
            {


            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

            ofd.Filter = "Image Files |*.jpg;*.jpeg;*.png*.bmp*.ico";
            ofd.Title = "Seleccione una imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(ofd.FileName);

            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string imagePath = ofd.FileName;
            byte[] imageData = File.ReadAllBytes(imagePath);
            string pub_id = cmbPubId.Text;
            string pr_info = txtPrInfo.Text;


            if (MessageBox.Show("Sus datos son correctos?", "Sistema - Pub_Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string consulta = "INSERT INTO pub_info(pub_id, logo, pr_info)VALUES(@pub_id, @logo, @pr_info)";
                        using (SqlCommand cmd = new SqlCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@pub_id", pub_id);
                            cmd.Parameters.AddWithValue("@logo", imageData);
                            cmd.Parameters.AddWithValue("@pr_info", pr_info);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        MessageBox.Show("Datos agregados correctamente", "Sistema - Pub_Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbPubId.Items.Clear();
                        cargarCombo();
                        cargarDgv();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Error: Usted ya registro anteriormente con el Id: " + pub_id);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error: " + ex.ToString(), "Sistema - Pub_Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("Seleccione una imagen antes de guardar");
                }
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cmbPubId.Text = "";
            txtPrInfo.Text = "";
            pictureBox.Image = null;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar los datos?", "Sistema - Pub_Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (dgvPubInfo.Rows.Count > 0)
                {
                    int pub_id = Convert.ToInt32(dgvPubInfo.SelectedRows[0].Cells["pub_id"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string consulta = "DELETE FROM pub_info WHERE pub_id = @pub_id";
                        using (SqlCommand cmd = new SqlCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@pub_id", pub_id);
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
            if (MessageBox.Show("Esta seguro que quiere modificar los datos?", "Sistema - Pub_Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (dgvPubInfo.SelectedRows.Count > 0)
                { 
                    string imagePath = ofd.FileName;
                    byte[] imageData = File.ReadAllBytes(imagePath);
                    int pub_id = Convert.ToInt32(dgvPubInfo.SelectedRows[0].Cells["pub_id"].Value);
                    string pr_info = txtPrInfo.Text;
                
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string consulta = "UPDATE pub_info set logo = @logo, pr_info = @pr_info WHERE pub_id = @pub_id";
                        using (SqlCommand cmd = new SqlCommand(consulta, conn))
                        {
                            cmd.Parameters.AddWithValue("@logo", imageData);
                            cmd.Parameters.AddWithValue("@pr_info", pr_info);
                            cmd.Parameters.AddWithValue("@pub_id", pub_id);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    MessageBox.Show("Datos modificados con exito", "Sistema - Pub_Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPubId.Items.Clear();
                    limpiar();
            }
        }
    }
}
