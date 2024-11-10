namespace _2024_11_02_TopAva_Pubs
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            label3 = new Label();
            btnAcceder = new Button();
            txtPassword = new TextBox();
            panelLogin = new Panel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT Condensed", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(196, 104);
            label1.Name = "label1";
            label1.Size = new Size(305, 74);
            label1.TabIndex = 0;
            label1.Text = "Publications";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 40);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(79, 58);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(229, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 84);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(194, 142);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(114, 23);
            btnAcceder.TabIndex = 5;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(79, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 6;
            // 
            // panelLogin
            // 
            panelLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogin.Controls.Add(txtUsuario);
            panelLogin.Controls.Add(btnAcceder);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label3);
            panelLogin.Location = new Point(196, 181);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(385, 207);
            panelLogin.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(749, 534);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "frmLogin";
            Text = "Login";
            Load += frmLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private Label label3;
        private Button btnAcceder;
        private TextBox txtPassword;
        private Panel panelLogin;
    }
}