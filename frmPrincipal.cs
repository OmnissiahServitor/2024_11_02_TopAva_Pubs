using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmPrincipal : Form
    {

        // Atributos
        DataSet ds;
        string emp_id;
        string connectionString = @"Data Source = localhost; Integrated Security = true; Initial catalog = pubs";

        public frmPrincipal()
        {

            InitializeComponent();
            this.CenterToScreen();
            // this.FormBorderStyle = FormBorderStyle.None;
            // this.WindowState = FormWindowState.Maximized;
            // MessageBox.Show("Ancho = " + this.Size.Width.ToString() + "\nAltura = " + this.Size.Height);
        } // end constructor default

        public frmPrincipal(string usuario, int nivel_acceso)
        {
            Datos dt = new Datos();
            InitializeComponent();
            this.CenterToScreen();



            emp_id = usuario;

            // el usuario es el emp_id, empieza a rellenar los campos de informacion sobre el usuario

            ds = dt.consulta("SELECT fname FROM employee WHERE emp_id = '" + usuario + "'");
            lab_FirstName.Text = ds.Tables[0].Rows[0]["fname"].ToString();

            ds = dt.consulta("SELECT lname FROM employee WHERE emp_id = '" + usuario + "'");
            lab_LastName.Text = ds.Tables[0].Rows[0]["lname"].ToString();

            ds = dt.consulta("SELECT j.job_desc " +
                "FROM jobs j, employee e " +
                "WHERE j.job_id = e.job_id AND e.emp_id = '" + usuario + "'");
            lab_jobDescription.Text = ds.Tables[0].Rows[0]["job_desc"].ToString();

            ds = dt.consulta("SELECT p.pub_name " +
                "FROM publishers p, employee e " +
                "WHERE p.pub_id = e.pub_id AND e.emp_id = '" + usuario + "'");
            lab_Publication.Text = ds.Tables[0].Rows[0]["pub_name"].ToString();

            if (nivel_acceso == 1) // acceso minimmo
            {
                autoresToolStripMenuItem.Enabled = true;
                publicadoresToolStripMenuItem.Enabled = true;
                titlesToolStripMenuItem.Enabled = true;
                titleAuthorToolStripMenuItem.Enabled = false;
                storesToolStripMenuItem.Enabled = false;
                salesToolStripMenuItem.Enabled = true;
                royschedToolStripMenuItem.Enabled = true;
                discountsToolStripMenuItem.Enabled = false;
                jobsToolStripMenuItem.Enabled = false;
                pubInfoToolStripMenuItem.Enabled = true;
                employeeToolStripMenuItem.Enabled = true;

                //MessageBox.Show("Acceso limitado");
            }
            else if (nivel_acceso == 2)
            { // acceso medio
                autoresToolStripMenuItem.Enabled = false;
                publicadoresToolStripMenuItem.Enabled = true;
                titlesToolStripMenuItem.Enabled = true;
                titleAuthorToolStripMenuItem.Enabled = true;
                storesToolStripMenuItem.Enabled = true;
                salesToolStripMenuItem.Enabled = true;
                royschedToolStripMenuItem.Enabled = false;
                discountsToolStripMenuItem.Enabled = true;
                jobsToolStripMenuItem.Enabled = false;
                pubInfoToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
            }
            else if (nivel_acceso == 3) // acceso completo
            {

            }


            //DataGridViewRow row = dgvPubInfo.Rows[e.RowIndex];

            //int pub_id = Convert.ToInt32(dgvPubInfo.Rows[e.RowIndex].Cells["pub_id"].Value);
            // Codigo que carga la imagen de la publicacion en el frmPrincipal
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // string consulta = "SELECT pubinf.logo FROM pub_info pubinf, pubs p, employee  WHERE pub_id = @pub_id";
                string consulta = "SELECT pi.logo FROM pub_info pi, publishers p, employee e " +
                    "WHERE p.pub_id = pi.pub_id AND e.pub_id = p.pub_id AND e.emp_id = '" + usuario + "'";

                using (SqlCommand cmd = new SqlCommand(consulta, conn))
                {
                    //cmd.Parameters.AddWithValue("@pub_id", pub_id); // @ le dice que es una variable
                    cmd.Parameters.AddWithValue("@emp_id", usuario);

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

            // Carga la imagen de la persona en el panelPortrait
            

            ds = dt.consulta("WITH EmployeeRows AS (" +
                "SELECT " +
                "ROW_NUMBER() OVER (ORDER BY emp_id) AS RowNumber," +
                " * " +
                "FROM employee)" +
                "SELECT RowNumber " +
                "FROM EmployeeRows " +
                "WHERE emp_id = '" + usuario + "'");

            int numEmployee = int.Parse( ds.Tables[0].Rows[0][0].ToString() );

            switch (numEmployee % 18)
            {
                case 0:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m1.jpg");
                    break;
                case 1:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f1.jpg");
                    break;
                case 2:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f2.jpg");
                    break;
                case 3:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m2.jpg");
                    break;
                case 4:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f3.jpg");
                    break;
                case 5:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m3.jpg");
                    break;
                case 6:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f4.jpg");
                    break;
                case 7:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m4.jpg");
                    break;
                case 8:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f5.jpg");
                    break;
                case 9:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m5.jpg");
                    break;
                case 10:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f6.jpg");
                    break;
                case 11:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m6.jpg");
                    break;
                case 12:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f7.jpg");
                    break;
                case 13:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m7.jpg");
                    break;
                case 14:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f8.jpg");
                    break;
                case 15:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\m8.jpg");
                    break;
                case 16:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f9.jpg");
                    break;
                case 17:
                    picturePortrait.Image = Image.FromFile("C:\\Users\\ivancenteno\\source\\repos\\2024_11_02_TopAva_Pubs_Angel_v1\\Imagenes\\f10.jpg");
                    break;
                default:
                    break;
            }
        } // end frmPrincipal con parametros

            private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // redondea el panelLogin
            int radio = 40;

            GraphicsPath path1 = new GraphicsPath();
            path1.StartFigure();

            path1.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // Esquina superior izquierda
            path1.AddArc(new Rectangle(panelPortrait.Width - radio, 0, radio, radio), 270, 90); // Esquina superior derecha
            path1.AddArc(new Rectangle(panelPortrait.Width - radio, panelPortrait.Height - radio, radio, radio), 0, 90); // Esquina inferior derecha
            path1.AddArc(new Rectangle(0, panelPortrait.Height - radio, radio, radio), 90, 90); // Esquina inferior izquierda
            path1.CloseFigure();

            GraphicsPath path2 = new GraphicsPath();
            path2.StartFigure();

            path2.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // Esquina superior izquierda
            path2.AddArc(new Rectangle(panelUsuario.Width - radio, 0, radio, radio), 270, 90); // Esquina superior derecha
            path2.AddArc(new Rectangle(panelUsuario.Width - radio, panelUsuario.Height - radio, radio, radio), 0, 90); // Esquina inferior derecha
            path2.AddArc(new Rectangle(0, panelUsuario.Height - radio, radio, radio), 90, 90); // Esquina inferior izquierda
            path2.CloseFigure();

            // Asigna la forma al panel
            panelPortrait.Region = new Region(path1);
            panelUsuario.Region = new Region(path2);

            panelUsuario.Left = (this.ClientSize.Width - panelUsuario.Width) / 2;
            panelUsuario.Top = (this.ClientSize.Height - panelUsuario.Height) / 2;
        }

        private void btnTitles_Resetear_Click(object sender, EventArgs e)
        {
            //actualizarTabla("titles");
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuthors frmAuthors = new frmAuthors();
            frmAuthors.Show();
        }

        private void publicadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishers frmPublishers = new frmPublishers();
            frmPublishers.Show();
        }

        private void titlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitles frmTitles = new frmTitles();
            frmTitles.Show();
        }

        private void titleAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitle_Author frmTitleAuthor = new frmTitle_Author();
            frmTitleAuthor.Show();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStores frmStores = new frmStores();
            frmStores.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales frmSales = new frmSales();
            frmSales.Show();
        }

        private void royschedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoysched frmRoysched = new frmRoysched();
            frmRoysched.Show();
        }

        private void discountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiscounts frmDiscounts = new frmDiscounts();
            frmDiscounts.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJobs frmJobs = new frmJobs();
            frmJobs.Show();
        }

        private void pubInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frm = new frmAcercaDe();
            frm.Show();
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarUsuario frm = new frmActualizarUsuario(lab_FirstName.Text, lab_LastName.Text, emp_id);
            frm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    } // end class frmPrincipal
} // end namespace