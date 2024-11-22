using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_11_02_TopAva_Pubs
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "PTC11962M";
            this.CenterToScreen();
        } // end constructor

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            DataSet ds;
            Datos dt = new Datos();
            int job_id = 0;
            int level_access = 0;
            string password = "";

            ds = dt.consulta("SELECT job_id FROM employee WHERE emp_id = '" +
                txtUsuario.Text +
                "'");

            if (ds.Tables[0].Rows.Count > 0) // Asegurarse de que hay filas en la tabla
            {
                job_id = int.Parse( ds.Tables[0].Rows[0]["job_id"].ToString() );
            }

            //MessageBox.Show("Job id = " + job_id);

            if ( job_id == 1 || (job_id <= 14 && job_id >= 12) ) // nivel minimo
                level_access = 1;
            else if (job_id <= 11 && job_id >= 7) // nivel medio
                level_access = 2;
            else if (job_id <= 6 && job_id >= 2 || job_id == 15) // nivel total
                level_access = 3;

            //MessageBox.Show("level access = " + level_access);

            try
            {
                ds = dt.consulta("SELECT fname FROM employee WHERE emp_id = '" +
                txtUsuario.Text +
                "'");

                if (ds.Tables[0].Rows.Count > 0) // Asegurarse de que hay filas en la tabla
                {
                    password = ds.Tables[0].Rows[0]["fname"].ToString();
                    //MessageBox.Show("password leida = " + password);

                }

                if (password == txtPassword.Text) // la contrasena es correcta
                {
                    MessageBox.Show("Acceso a usuario " + txtUsuario.Text, " concedido", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    frmPrincipal frmPrincipal = new frmPrincipal(txtUsuario.Text, level_access);
                    frmPrincipal.Show();
                    this.Hide();
                }
                else // la contrasena es incorrecta
                {
                    MessageBox.Show("Wrong Password. \nTry again.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end btnAcceder

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // redondea el panelLogin
            int radio = 40;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(panelLogin.Width - radio, 0, radio, radio), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(panelLogin.Width - radio, panelLogin.Height - radio, radio, radio), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, panelLogin.Height - radio, radio, radio), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asigna la forma al panel
            panelLogin.Region = new Region(path);
        } // end frmLogin_Load

        
    } // end frmLogin
} // end namespace
