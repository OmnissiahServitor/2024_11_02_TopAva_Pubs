namespace _2024_11_02_TopAva_Pubs
{
    partial class frmEmployee
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
            nudJobLvl = new NumericUpDown();
            dtEmployee = new DateTimePicker();
            cmbPubId = new ComboBox();
            cmbJobId = new ComboBox();
            txtFname = new TextBox();
            txtMinit = new TextBox();
            txtLastName = new TextBox();
            txtEmployeeId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label2 = new Label();
            panel19 = new Panel();
            btn_Resetear = new Button();
            label7 = new Label();
            btn_Buscar = new Button();
            label19 = new Label();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            dgvEmployee = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLvl).BeginInit();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 255, 255);
            panel8.Controls.Add(nudJobLvl);
            panel8.Controls.Add(dtEmployee);
            panel8.Controls.Add(cmbPubId);
            panel8.Controls.Add(cmbJobId);
            panel8.Controls.Add(txtFname);
            panel8.Controls.Add(txtMinit);
            panel8.Controls.Add(txtLastName);
            panel8.Controls.Add(txtEmployeeId);
            panel8.Controls.Add(label9);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(btnEliminar);
            panel8.Controls.Add(btnModificar);
            panel8.Controls.Add(btnGuardar);
            panel8.Controls.Add(btnLimpiar);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(509, 509);
            panel8.TabIndex = 10;
            // 
            // nudJobLvl
            // 
            nudJobLvl.Location = new Point(134, 207);
            nudJobLvl.Name = "nudJobLvl";
            nudJobLvl.Size = new Size(120, 23);
            nudJobLvl.TabIndex = 59;
            // 
            // dtEmployee
            // 
            dtEmployee.Location = new Point(133, 275);
            dtEmployee.Name = "dtEmployee";
            dtEmployee.Size = new Size(232, 23);
            dtEmployee.TabIndex = 58;
            // 
            // cmbPubId
            // 
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Location = new Point(133, 235);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(121, 23);
            cmbPubId.TabIndex = 57;
            // 
            // cmbJobId
            // 
            cmbJobId.FormattingEnabled = true;
            cmbJobId.Location = new Point(133, 177);
            cmbJobId.Name = "cmbJobId";
            cmbJobId.Size = new Size(121, 23);
            cmbJobId.TabIndex = 55;
            cmbJobId.SelectedIndexChanged += cmbJobId_SelectedIndexChanged;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(133, 87);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(121, 23);
            txtFname.TabIndex = 54;
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(133, 116);
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(121, 23);
            txtMinit.TabIndex = 53;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(133, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 52;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Location = new Point(133, 57);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(121, 23);
            txtEmployeeId.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 281);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 50;
            label9.Text = "Hire date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 176);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 49;
            label8.Text = "Job Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 209);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 48;
            label6.Text = "Job Level";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 238);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 47;
            label5.Text = "Publisher Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 148);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 46;
            label4.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 119);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 45;
            label1.Text = "Minit";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(83, 404);
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
            btnModificar.Location = new Point(83, 317);
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
            btnGuardar.Location = new Point(83, 346);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(83, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 90);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 60);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Employee_Id";
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
            panel19.Location = new Point(527, 12);
            panel19.Name = "panel19";
            panel19.Size = new Size(494, 170);
            panel19.TabIndex = 11;
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
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(527, 188);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(494, 333);
            dgvEmployee.TabIndex = 42;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // frmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 544);
            Controls.Add(dgvEmployee);
            Controls.Add(panel19);
            Controls.Add(panel8);
            Name = "frmEmployee";
            Text = "frmEmployee";
            Load += frmEmployee_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudJobLvl).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label3;
        private Label label2;
        private Panel panel19;
        private Button btn_Resetear;
        private Label label7;
        private Button btn_Buscar;
        private Label label19;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
        private DataGridView dgvEmployee;
        private Label label4;
        private Label label1;
        private Label label8;
        private Label label6;
        private Label label5;
        private DateTimePicker dtEmployee;
        private ComboBox cmbPubId;
        private ComboBox cmbJobId;
        private TextBox txtFname;
        private TextBox txtMinit;
        private TextBox txtLastName;
        private TextBox txtEmployeeId;
        private Label label9;
        private NumericUpDown nudJobLvl;
    }
}