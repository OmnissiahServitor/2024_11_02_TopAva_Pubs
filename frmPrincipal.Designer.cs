namespace _2024_11_02_TopAva_Pubs
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            inputToolStripMenuItem = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            publicadoresToolStripMenuItem = new ToolStripMenuItem();
            titlesToolStripMenuItem = new ToolStripMenuItem();
            titleAuthorToolStripMenuItem = new ToolStripMenuItem();
            storesToolStripMenuItem = new ToolStripMenuItem();
            salesToolStripMenuItem = new ToolStripMenuItem();
            royschedToolStripMenuItem = new ToolStripMenuItem();
            discountsToolStripMenuItem = new ToolStripMenuItem();
            jobsToolStripMenuItem = new ToolStripMenuItem();
            pubInfoToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            labUsuario = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lab_FirstName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lab_LastName = new Label();
            lab_jobDescription = new Label();
            lab_Publication = new Label();
            panelPortrait = new Panel();
            picturePortrait = new PictureBox();
            panelUsuario = new Panel();
            pictureBox = new PictureBox();
            butActualizar = new Button();
            menuStrip1.SuspendLayout();
            panelPortrait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePortrait).BeginInit();
            panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, inputToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1008, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // inputToolStripMenuItem
            // 
            inputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, publicadoresToolStripMenuItem, titlesToolStripMenuItem, titleAuthorToolStripMenuItem, storesToolStripMenuItem, salesToolStripMenuItem, royschedToolStripMenuItem, discountsToolStripMenuItem, jobsToolStripMenuItem, pubInfoToolStripMenuItem, employeeToolStripMenuItem, tablasToolStripMenuItem });
            inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            inputToolStripMenuItem.Size = new Size(51, 20);
            inputToolStripMenuItem.Text = "Tablas";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(180, 22);
            autoresToolStripMenuItem.Text = "Authors";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // publicadoresToolStripMenuItem
            // 
            publicadoresToolStripMenuItem.Name = "publicadoresToolStripMenuItem";
            publicadoresToolStripMenuItem.Size = new Size(180, 22);
            publicadoresToolStripMenuItem.Text = "Publishers";
            publicadoresToolStripMenuItem.Click += publicadoresToolStripMenuItem_Click;
            // 
            // titlesToolStripMenuItem
            // 
            titlesToolStripMenuItem.Name = "titlesToolStripMenuItem";
            titlesToolStripMenuItem.Size = new Size(180, 22);
            titlesToolStripMenuItem.Text = "Titles";
            titlesToolStripMenuItem.Click += titlesToolStripMenuItem_Click;
            // 
            // titleAuthorToolStripMenuItem
            // 
            titleAuthorToolStripMenuItem.Name = "titleAuthorToolStripMenuItem";
            titleAuthorToolStripMenuItem.Size = new Size(180, 22);
            titleAuthorToolStripMenuItem.Text = "Title - Author";
            titleAuthorToolStripMenuItem.Click += titleAuthorToolStripMenuItem_Click;
            // 
            // storesToolStripMenuItem
            // 
            storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            storesToolStripMenuItem.Size = new Size(180, 22);
            storesToolStripMenuItem.Text = "Stores";
            storesToolStripMenuItem.Click += storesToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(180, 22);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // royschedToolStripMenuItem
            // 
            royschedToolStripMenuItem.Name = "royschedToolStripMenuItem";
            royschedToolStripMenuItem.Size = new Size(180, 22);
            royschedToolStripMenuItem.Text = "Roysched";
            royschedToolStripMenuItem.Click += royschedToolStripMenuItem_Click;
            // 
            // discountsToolStripMenuItem
            // 
            discountsToolStripMenuItem.Name = "discountsToolStripMenuItem";
            discountsToolStripMenuItem.Size = new Size(180, 22);
            discountsToolStripMenuItem.Text = "Discounts";
            discountsToolStripMenuItem.Click += discountsToolStripMenuItem_Click;
            // 
            // jobsToolStripMenuItem
            // 
            jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            jobsToolStripMenuItem.Size = new Size(180, 22);
            jobsToolStripMenuItem.Text = "Jobs";
            jobsToolStripMenuItem.Click += jobsToolStripMenuItem_Click;
            // 
            // pubInfoToolStripMenuItem
            // 
            pubInfoToolStripMenuItem.Name = "pubInfoToolStripMenuItem";
            pubInfoToolStripMenuItem.Size = new Size(180, 22);
            pubInfoToolStripMenuItem.Text = "Pub info";
            pubInfoToolStripMenuItem.Click += pubInfoToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(180, 22);
            employeeToolStripMenuItem.Text = "Employee";
            employeeToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(180, 22);
            tablasToolStripMenuItem.Text = "Tablas";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(80, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.Font = new Font("Segoe UI", 12F);
            labUsuario.Location = new Point(336, 109);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(89, 21);
            labUsuario.TabIndex = 3;
            labUsuario.Text = "First Name:";
            // 
            // lab_FirstName
            // 
            lab_FirstName.AutoSize = true;
            lab_FirstName.Font = new Font("Segoe UI", 12F);
            lab_FirstName.Location = new Point(431, 109);
            lab_FirstName.Name = "lab_FirstName";
            lab_FirstName.Size = new Size(49, 21);
            lab_FirstName.TabIndex = 5;
            lab_FirstName.Text = "name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(338, 141);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 6;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(305, 173);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 7;
            label4.Text = "Job Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(272, 205);
            label5.Name = "label5";
            label5.Size = new Size(153, 21);
            label5.TabIndex = 8;
            label5.Text = "Publication Location:";
            // 
            // lab_LastName
            // 
            lab_LastName.AutoSize = true;
            lab_LastName.Font = new Font("Segoe UI", 12F);
            lab_LastName.Location = new Point(431, 141);
            lab_LastName.Name = "lab_LastName";
            lab_LastName.Size = new Size(49, 21);
            lab_LastName.TabIndex = 9;
            lab_LastName.Text = "name";
            // 
            // lab_jobDescription
            // 
            lab_jobDescription.AutoSize = true;
            lab_jobDescription.Font = new Font("Segoe UI", 12F);
            lab_jobDescription.Location = new Point(431, 173);
            lab_jobDescription.Name = "lab_jobDescription";
            lab_jobDescription.Size = new Size(49, 21);
            lab_jobDescription.TabIndex = 10;
            lab_jobDescription.Text = "name";
            // 
            // lab_Publication
            // 
            lab_Publication.AutoSize = true;
            lab_Publication.Font = new Font("Segoe UI", 12F);
            lab_Publication.Location = new Point(431, 205);
            lab_Publication.Name = "lab_Publication";
            lab_Publication.Size = new Size(49, 21);
            lab_Publication.TabIndex = 11;
            lab_Publication.Text = "name";
            // 
            // panelPortrait
            // 
            panelPortrait.BackColor = Color.FromArgb(255, 192, 128);
            panelPortrait.Controls.Add(picturePortrait);
            panelPortrait.Location = new Point(33, 26);
            panelPortrait.Name = "panelPortrait";
            panelPortrait.Size = new Size(200, 200);
            panelPortrait.TabIndex = 12;
            // 
            // picturePortrait
            // 
            picturePortrait.BackColor = Color.FromArgb(192, 255, 192);
            picturePortrait.Dock = DockStyle.Fill;
            picturePortrait.Location = new Point(0, 0);
            picturePortrait.Name = "picturePortrait";
            picturePortrait.Size = new Size(200, 200);
            picturePortrait.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePortrait.TabIndex = 0;
            picturePortrait.TabStop = false;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(255, 192, 128);
            panelUsuario.Controls.Add(pictureBox);
            panelUsuario.Controls.Add(butActualizar);
            panelUsuario.Controls.Add(panelPortrait);
            panelUsuario.Controls.Add(labUsuario);
            panelUsuario.Controls.Add(lab_Publication);
            panelUsuario.Controls.Add(lab_FirstName);
            panelUsuario.Controls.Add(lab_jobDescription);
            panelUsuario.Controls.Add(label3);
            panelUsuario.Controls.Add(lab_LastName);
            panelUsuario.Controls.Add(label4);
            panelUsuario.Controls.Add(label5);
            panelUsuario.Location = new Point(120, 275);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(662, 298);
            panelUsuario.TabIndex = 13;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Location = new Point(305, 26);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(343, 59);
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // butActualizar
            // 
            butActualizar.Location = new Point(33, 250);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(200, 23);
            butActualizar.TabIndex = 13;
            butActualizar.Text = "Actualizar Datos";
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 639);
            Controls.Add(panelUsuario);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Base de Datos";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelPortrait.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePortrait).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem inputToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem publicadoresToolStripMenuItem;
        private ToolStripMenuItem titlesToolStripMenuItem;
        private ToolStripMenuItem titleAuthorToolStripMenuItem;
        private ToolStripMenuItem storesToolStripMenuItem;
        private ToolStripMenuItem salesToolStripMenuItem;
        private ToolStripMenuItem royschedToolStripMenuItem;
        private ToolStripMenuItem discountsToolStripMenuItem;
        private ToolStripMenuItem jobsToolStripMenuItem;
        private ToolStripMenuItem pubInfoToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private Label labUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem tablasToolStripMenuItem;
        private Label lab_FirstName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lab_LastName;
        private Label lab_jobDescription;
        private Label lab_Publication;
        private Panel panelPortrait;
        private Panel panelUsuario;
        private Button butActualizar;
        private PictureBox pictureBox;
        private PictureBox picturePortrait;
    }
}
