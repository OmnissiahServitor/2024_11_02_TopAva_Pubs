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
            eToolStripMenuItem = new ToolStripMenuItem();
            tablasToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            labUsuario = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, inputToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(634, 24);
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
            inputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoresToolStripMenuItem, publicadoresToolStripMenuItem, titlesToolStripMenuItem, titleAuthorToolStripMenuItem, storesToolStripMenuItem, salesToolStripMenuItem, royschedToolStripMenuItem, discountsToolStripMenuItem, jobsToolStripMenuItem, pubInfoToolStripMenuItem, eToolStripMenuItem, tablasToolStripMenuItem });
            inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            inputToolStripMenuItem.Size = new Size(51, 20);
            inputToolStripMenuItem.Text = "Tablas";
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(144, 22);
            autoresToolStripMenuItem.Text = "Authors";
            autoresToolStripMenuItem.Click += autoresToolStripMenuItem_Click;
            // 
            // publicadoresToolStripMenuItem
            // 
            publicadoresToolStripMenuItem.Name = "publicadoresToolStripMenuItem";
            publicadoresToolStripMenuItem.Size = new Size(144, 22);
            publicadoresToolStripMenuItem.Text = "Publishers";
            publicadoresToolStripMenuItem.Click += publicadoresToolStripMenuItem_Click;
            // 
            // titlesToolStripMenuItem
            // 
            titlesToolStripMenuItem.Name = "titlesToolStripMenuItem";
            titlesToolStripMenuItem.Size = new Size(144, 22);
            titlesToolStripMenuItem.Text = "Titles";
            titlesToolStripMenuItem.Click += titlesToolStripMenuItem_Click;
            // 
            // titleAuthorToolStripMenuItem
            // 
            titleAuthorToolStripMenuItem.Name = "titleAuthorToolStripMenuItem";
            titleAuthorToolStripMenuItem.Size = new Size(144, 22);
            titleAuthorToolStripMenuItem.Text = "Title - Author";
            titleAuthorToolStripMenuItem.Click += titleAuthorToolStripMenuItem_Click;
            // 
            // storesToolStripMenuItem
            // 
            storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            storesToolStripMenuItem.Size = new Size(144, 22);
            storesToolStripMenuItem.Text = "Stores";
            storesToolStripMenuItem.Click += storesToolStripMenuItem_Click;
            // 
            // salesToolStripMenuItem
            // 
            salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            salesToolStripMenuItem.Size = new Size(144, 22);
            salesToolStripMenuItem.Text = "Sales";
            salesToolStripMenuItem.Click += salesToolStripMenuItem_Click;
            // 
            // royschedToolStripMenuItem
            // 
            royschedToolStripMenuItem.Name = "royschedToolStripMenuItem";
            royschedToolStripMenuItem.Size = new Size(144, 22);
            royschedToolStripMenuItem.Text = "Roysched";
            royschedToolStripMenuItem.Click += royschedToolStripMenuItem_Click;
            // 
            // discountsToolStripMenuItem
            // 
            discountsToolStripMenuItem.Name = "discountsToolStripMenuItem";
            discountsToolStripMenuItem.Size = new Size(144, 22);
            discountsToolStripMenuItem.Text = "Discounts";
            discountsToolStripMenuItem.Click += discountsToolStripMenuItem_Click;
            // 
            // jobsToolStripMenuItem
            // 
            jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            jobsToolStripMenuItem.Size = new Size(144, 22);
            jobsToolStripMenuItem.Text = "Jobs";
            jobsToolStripMenuItem.Click += jobsToolStripMenuItem_Click;
            // 
            // pubInfoToolStripMenuItem
            // 
            pubInfoToolStripMenuItem.Name = "pubInfoToolStripMenuItem";
            pubInfoToolStripMenuItem.Size = new Size(144, 22);
            pubInfoToolStripMenuItem.Text = "Pub info";
            pubInfoToolStripMenuItem.Click += pubInfoToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(144, 22);
            eToolStripMenuItem.Text = "Employee";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // tablasToolStripMenuItem
            // 
            tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            tablasToolStripMenuItem.Size = new Size(144, 22);
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
            labUsuario.Location = new Point(150, 173);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(67, 21);
            labUsuario.TabIndex = 3;
            labUsuario.Text = "Usuario:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 461);
            Controls.Add(labUsuario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Base de Datos";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem eToolStripMenuItem;
        private Label labUsuario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem tablasToolStripMenuItem;
    }
}
