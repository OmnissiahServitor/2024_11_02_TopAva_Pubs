namespace _2024_11_02_TopAva_Pubs
{
    partial class frmAuthors
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
            panel12 = new Panel();
            btnResetearAuthors = new Button();
            txtAuthorBuscar = new TextBox();
            label12 = new Label();
            btnAuthorBuscar = new Button();
            cmbAuthorSearchBy = new ComboBox();
            label11 = new Label();
            panel1 = new Panel();
            chkAuthorContract = new CheckBox();
            btnAuthorEliminar = new Button();
            btnAuthorModificar = new Button();
            btnAuthorLimpiar = new Button();
            btnAuthorGuardar = new Button();
            mskZip = new MaskedTextBox();
            label9 = new Label();
            txtCity = new TextBox();
            label8 = new Label();
            mskState = new MaskedTextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            mskPhone = new MaskedTextBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            label5 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            mskAuthorID = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            dgvAuthors = new DataGridView();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(255, 224, 192);
            panel12.Controls.Add(btnResetearAuthors);
            panel12.Controls.Add(txtAuthorBuscar);
            panel12.Controls.Add(label12);
            panel12.Controls.Add(btnAuthorBuscar);
            panel12.Controls.Add(cmbAuthorSearchBy);
            panel12.Controls.Add(label11);
            panel12.Location = new Point(448, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(1180, 151);
            panel12.TabIndex = 8;
            // 
            // btnResetearAuthors
            // 
            btnResetearAuthors.Font = new Font("Segoe UI", 12F);
            btnResetearAuthors.Location = new Point(1064, 77);
            btnResetearAuthors.Name = "btnResetearAuthors";
            btnResetearAuthors.Size = new Size(100, 29);
            btnResetearAuthors.TabIndex = 6;
            btnResetearAuthors.Text = "Resetear";
            btnResetearAuthors.UseVisualStyleBackColor = true;
            btnResetearAuthors.Click += btnResetearAuthors_Click;
            // 
            // txtAuthorBuscar
            // 
            txtAuthorBuscar.Font = new Font("Segoe UI", 12F);
            txtAuthorBuscar.Location = new Point(700, 77);
            txtAuthorBuscar.Name = "txtAuthorBuscar";
            txtAuthorBuscar.Size = new Size(252, 29);
            txtAuthorBuscar.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(21, 45);
            label12.Name = "label12";
            label12.Size = new Size(287, 50);
            label12.TabIndex = 4;
            label12.Text = "Lista de Authors";
            // 
            // btnAuthorBuscar
            // 
            btnAuthorBuscar.Font = new Font("Segoe UI", 12F);
            btnAuthorBuscar.Location = new Point(958, 76);
            btnAuthorBuscar.Name = "btnAuthorBuscar";
            btnAuthorBuscar.Size = new Size(100, 29);
            btnAuthorBuscar.TabIndex = 2;
            btnAuthorBuscar.Text = "Buscar";
            btnAuthorBuscar.UseVisualStyleBackColor = true;
            btnAuthorBuscar.Click += btnAuthorBuscar_Click;
            // 
            // cmbAuthorSearchBy
            // 
            cmbAuthorSearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAuthorSearchBy.FormattingEnabled = true;
            cmbAuthorSearchBy.Location = new Point(494, 77);
            cmbAuthorSearchBy.Name = "cmbAuthorSearchBy";
            cmbAuthorSearchBy.Size = new Size(200, 29);
            cmbAuthorSearchBy.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(401, 80);
            label11.Name = "label11";
            label11.Size = new Size(87, 21);
            label11.TabIndex = 0;
            label11.Text = "Buscar por:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(chkAuthorContract);
            panel1.Controls.Add(btnAuthorEliminar);
            panel1.Controls.Add(btnAuthorModificar);
            panel1.Controls.Add(btnAuthorLimpiar);
            panel1.Controls.Add(btnAuthorGuardar);
            panel1.Controls.Add(mskZip);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtCity);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(mskState);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(mskPhone);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(mskAuthorID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 753);
            panel1.TabIndex = 7;
            // 
            // chkAuthorContract
            // 
            chkAuthorContract.AutoSize = true;
            chkAuthorContract.BackColor = Color.FromArgb(255, 255, 192);
            chkAuthorContract.Location = new Point(39, 576);
            chkAuthorContract.Name = "chkAuthorContract";
            chkAuthorContract.Size = new Size(72, 19);
            chkAuthorContract.TabIndex = 21;
            chkAuthorContract.Text = "Contract";
            chkAuthorContract.UseVisualStyleBackColor = false;
            // 
            // btnAuthorEliminar
            // 
            btnAuthorEliminar.BackColor = Color.Maroon;
            btnAuthorEliminar.ForeColor = Color.White;
            btnAuthorEliminar.Location = new Point(37, 718);
            btnAuthorEliminar.Name = "btnAuthorEliminar";
            btnAuthorEliminar.Size = new Size(334, 23);
            btnAuthorEliminar.TabIndex = 20;
            btnAuthorEliminar.Text = "Eliminar";
            btnAuthorEliminar.UseVisualStyleBackColor = false;
            btnAuthorEliminar.Click += btnAuthorEliminar_Click;
            // 
            // btnAuthorModificar
            // 
            btnAuthorModificar.Font = new Font("Segoe UI", 9F);
            btnAuthorModificar.Location = new Point(37, 631);
            btnAuthorModificar.Name = "btnAuthorModificar";
            btnAuthorModificar.Size = new Size(334, 23);
            btnAuthorModificar.TabIndex = 3;
            btnAuthorModificar.Text = "Modificar";
            btnAuthorModificar.UseVisualStyleBackColor = true;
            btnAuthorModificar.Click += btnAuthorModificar_Click;
            // 
            // btnAuthorLimpiar
            // 
            btnAuthorLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnAuthorLimpiar.ForeColor = Color.White;
            btnAuthorLimpiar.Location = new Point(37, 689);
            btnAuthorLimpiar.Name = "btnAuthorLimpiar";
            btnAuthorLimpiar.Size = new Size(334, 23);
            btnAuthorLimpiar.TabIndex = 19;
            btnAuthorLimpiar.Text = "Limpiar";
            btnAuthorLimpiar.UseVisualStyleBackColor = false;
            btnAuthorLimpiar.Click += btnAuthorLimpiar_Click;
            // 
            // btnAuthorGuardar
            // 
            btnAuthorGuardar.BackColor = Color.Green;
            btnAuthorGuardar.ForeColor = Color.White;
            btnAuthorGuardar.Location = new Point(37, 660);
            btnAuthorGuardar.Name = "btnAuthorGuardar";
            btnAuthorGuardar.Size = new Size(334, 23);
            btnAuthorGuardar.TabIndex = 18;
            btnAuthorGuardar.Text = "Guardar";
            btnAuthorGuardar.UseVisualStyleBackColor = false;
            btnAuthorGuardar.Click += btnAuthorGuardar_Click;
            // 
            // mskZip
            // 
            mskZip.Location = new Point(37, 517);
            mskZip.Mask = "99999";
            mskZip.Name = "mskZip";
            mskZip.Size = new Size(332, 23);
            mskZip.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 499);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 14;
            label9.Text = "Zip:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(38, 400);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(332, 23);
            txtCity.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 382);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 12;
            label8.Text = "City:";
            // 
            // mskState
            // 
            mskState.Location = new Point(38, 455);
            mskState.Mask = "AA";
            mskState.Name = "mskState";
            mskState.Size = new Size(332, 23);
            mskState.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 437);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 10;
            label7.Text = "State:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(37, 336);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(332, 23);
            txtAddress.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 318);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 8;
            label6.Text = "Address:";
            // 
            // mskPhone
            // 
            mskPhone.Location = new Point(38, 269);
            mskPhone.Mask = "999 999-9999";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(332, 23);
            mskPhone.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 251);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Phone:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(37, 213);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(332, 23);
            txtFirstName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 195);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 5;
            label5.Text = "First Name:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(38, 154);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(332, 23);
            txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 136);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // mskAuthorID
            // 
            mskAuthorID.Location = new Point(38, 94);
            mskAuthorID.Mask = "999-99-9999";
            mskAuthorID.Name = "mskAuthorID";
            mskAuthorID.Size = new Size(332, 23);
            mskAuthorID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 76);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 37);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 0;
            label2.Text = "Detalle Authors";
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(448, 184);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.Size = new Size(1180, 581);
            dgvAuthors.TabIndex = 6;
            // 
            // frmAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 780);
            Controls.Add(panel12);
            Controls.Add(panel1);
            Controls.Add(dgvAuthors);
            Name = "frmAuthors";
            Text = "Authors Table";
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel12;
        private Button btnResetearAuthors;
        private TextBox txtAuthorBuscar;
        private Label label12;
        private Button btnAuthorBuscar;
        private ComboBox cmbAuthorSearchBy;
        private Label label11;
        private Panel panel1;
        private CheckBox chkAuthorContract;
        private Button btnAuthorEliminar;
        private Button btnAuthorModificar;
        private Button btnAuthorLimpiar;
        private Button btnAuthorGuardar;
        private MaskedTextBox mskZip;
        private Label label9;
        private TextBox txtCity;
        private Label label8;
        private MaskedTextBox mskState;
        private Label label7;
        private TextBox txtAddress;
        private Label label6;
        private MaskedTextBox mskPhone;
        private Label label1;
        private TextBox txtFirstName;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private MaskedTextBox mskAuthorID;
        private Label label3;
        private Label label2;
        private DataGridView dgvAuthors;
    }
}