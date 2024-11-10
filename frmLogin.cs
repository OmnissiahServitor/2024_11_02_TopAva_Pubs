using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            txtUsuario.Text = "ADMIN";
            this.CenterToScreen();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acceso a usuario " + txtUsuario.Text, "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            frmPrincipal frmPrincipal = new frmPrincipal(txtUsuario.Text);
            frmPrincipal.Show();
            this.Hide();
        }

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
        }

        
    }
}
