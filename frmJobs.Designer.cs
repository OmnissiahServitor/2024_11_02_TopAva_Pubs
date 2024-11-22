namespace _2024_11_02_TopAva_Pubs
{
    partial class frmJobs
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
            panel8 = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            numMaxLvl = new NumericUpDown();
            btnLimpiar = new Button();
            numMinLvl = new NumericUpDown();
            txtJobDesc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel19 = new Panel();
            btn_Resetear = new Button();
            label7 = new Label();
            btn_Buscar = new Button();
            label19 = new Label();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            dgvJobs = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLvl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinLvl).BeginInit();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 255, 255);
            panel8.Controls.Add(btnEliminar);
            panel8.Controls.Add(btnModificar);
            panel8.Controls.Add(btnGuardar);
            panel8.Controls.Add(numMaxLvl);
            panel8.Controls.Add(btnLimpiar);
            panel8.Controls.Add(numMinLvl);
            panel8.Controls.Add(txtJobDesc);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(12, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(414, 519);
            panel8.TabIndex = 9;
            panel8.Paint += panel8_Paint;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(49, 304);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(330, 23);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.Location = new Point(49, 217);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(330, 23);
            btnModificar.TabIndex = 41;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(49, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numMaxLvl
            // 
            numMaxLvl.Location = new Point(191, 176);
            numMaxLvl.Name = "numMaxLvl";
            numMaxLvl.Size = new Size(174, 23);
            numMaxLvl.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(49, 275);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // numMinLvl
            // 
            numMinLvl.Location = new Point(191, 140);
            numMinLvl.Name = "numMinLvl";
            numMinLvl.Size = new Size(174, 23);
            numMinLvl.TabIndex = 9;
            // 
            // txtJobDesc
            // 
            txtJobDesc.Location = new Point(191, 111);
            txtJobDesc.Name = "txtJobDesc";
            txtJobDesc.Size = new Size(174, 23);
            txtJobDesc.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 178);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "High Level";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 142);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Minimum Lvl";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 114);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Jobs Description";
            // 
            // panel19
            // 
            panel19.BackColor = Color.FromArgb(255, 224, 192);
            panel19.Controls.Add(btn_Resetear);
            panel19.Controls.Add(label7);
            panel19.Controls.Add(btn_Buscar);
            panel19.Controls.Add(label19);
            panel19.Controls.Add(txt_Buscar);
            panel19.Controls.Add(cmb_SearchBy);
            panel19.Location = new Point(432, 3);
            panel19.Name = "panel19";
            panel19.Size = new Size(494, 170);
            panel19.TabIndex = 10;
            // 
            // btn_Resetear
            // 
            btn_Resetear.Font = new Font("Segoe UI", 12F);
            btn_Resetear.Location = new Point(377, 122);
            btn_Resetear.Name = "btn_Resetear";
            btn_Resetear.Size = new Size(100, 29);
            btn_Resetear.TabIndex = 40;
            btn_Resetear.Text = "Resetear";
            btn_Resetear.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(45, 26);
            label7.Name = "label7";
            label7.Size = new Size(159, 45);
            label7.TabIndex = 37;
            label7.Text = "Busqueda";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F);
            btn_Buscar.Location = new Point(271, 123);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(100, 29);
            btn_Buscar.TabIndex = 38;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(18, 90);
            label19.Name = "label19";
            label19.Size = new Size(87, 21);
            label19.TabIndex = 36;
            label19.Text = "Buscar por:";
            // 
            // txt_Buscar
            // 
            txt_Buscar.Font = new Font("Segoe UI", 12F);
            txt_Buscar.Location = new Point(286, 87);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(191, 29);
            txt_Buscar.TabIndex = 39;
            // 
            // cmb_SearchBy
            // 
            cmb_SearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_SearchBy.FormattingEnabled = true;
            cmb_SearchBy.Location = new Point(111, 87);
            cmb_SearchBy.Name = "cmb_SearchBy";
            cmb_SearchBy.Size = new Size(169, 29);
            cmb_SearchBy.TabIndex = 37;
            // 
            // dgvJobs
            // 
            dgvJobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJobs.Location = new Point(432, 179);
            dgvJobs.Name = "dgvJobs";
            dgvJobs.Size = new Size(494, 333);
            dgvJobs.TabIndex = 11;
            dgvJobs.CellClick += dgvJobs_CellClick_1;
            dgvJobs.CellContentClick += dgvJobs_CellContentClick;
            // 
            // frmJobs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 534);
            Controls.Add(dgvJobs);
            Controls.Add(panel19);
            Controls.Add(panel8);
            Name = "frmJobs";
            Text = "frmJobs";
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLvl).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinLvl).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvJobs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private NumericUpDown numMaxLvl;
        private Button btnLimpiar;
        private NumericUpDown numMinLvl;
        private TextBox txtJobDesc;
        private Label label5;
        private Label label4;
        private Label label1;
        private Panel panel19;
        private Button btn_Resetear;
        private Label label7;
        private Button btn_Buscar;
        private Label label19;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
        private DataGridView dgvJobs;
    }
}