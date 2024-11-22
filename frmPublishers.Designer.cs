namespace _2024_11_02_TopAva_Pubs
{
    partial class frmPublishers
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
            panel13 = new Panel();
            btnPublishers_Resetear = new Button();
            label18 = new Label();
            txtPublishers_Buscar = new TextBox();
            label19 = new Label();
            cmbPublishers_SearchBy = new ComboBox();
            btnPublishers_Buscar = new Button();
            panel2 = new Panel();
            txtPublisher_Country = new TextBox();
            label17 = new Label();
            mskPublisher_State = new MaskedTextBox();
            label16 = new Label();
            txtPublisher_City = new TextBox();
            label15 = new Label();
            txtPublisher_name = new TextBox();
            label14 = new Label();
            mskPublishers_ID = new MaskedTextBox();
            label10 = new Label();
            label13 = new Label();
            btnPublishersEliminar = new Button();
            btnPublishersModificar = new Button();
            btnPublishersGuardar = new Button();
            btnPublishersLimpiar = new Button();
            dgvPublishers = new DataGridView();
            panel13.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).BeginInit();
            SuspendLayout();
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(255, 224, 192);
            panel13.Controls.Add(btnPublishers_Resetear);
            panel13.Controls.Add(label18);
            panel13.Controls.Add(txtPublishers_Buscar);
            panel13.Controls.Add(label19);
            panel13.Controls.Add(cmbPublishers_SearchBy);
            panel13.Controls.Add(btnPublishers_Buscar);
            panel13.Location = new Point(448, 9);
            panel13.Name = "panel13";
            panel13.Size = new Size(1180, 151);
            panel13.TabIndex = 9;
            // 
            // btnPublishers_Resetear
            // 
            btnPublishers_Resetear.Font = new Font("Segoe UI", 12F);
            btnPublishers_Resetear.Location = new Point(1063, 91);
            btnPublishers_Resetear.Name = "btnPublishers_Resetear";
            btnPublishers_Resetear.Size = new Size(100, 29);
            btnPublishers_Resetear.TabIndex = 12;
            btnPublishers_Resetear.Text = "Resetear";
            btnPublishers_Resetear.UseVisualStyleBackColor = true;
            btnPublishers_Resetear.Click += btnPublishers_Resetear_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 36F);
            label18.Location = new Point(24, 59);
            label18.Name = "label18";
            label18.Size = new Size(417, 65);
            label18.TabIndex = 10;
            label18.Text = "Lista de Publishers";
            // 
            // txtPublishers_Buscar
            // 
            txtPublishers_Buscar.Font = new Font("Segoe UI", 12F);
            txtPublishers_Buscar.Location = new Point(739, 90);
            txtPublishers_Buscar.Name = "txtPublishers_Buscar";
            txtPublishers_Buscar.Size = new Size(212, 29);
            txtPublishers_Buscar.TabIndex = 11;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(447, 94);
            label19.Name = "label19";
            label19.Size = new Size(87, 21);
            label19.TabIndex = 7;
            label19.Text = "Buscar por:";
            // 
            // cmbPublishers_SearchBy
            // 
            cmbPublishers_SearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPublishers_SearchBy.FormattingEnabled = true;
            cmbPublishers_SearchBy.Location = new Point(540, 91);
            cmbPublishers_SearchBy.Name = "cmbPublishers_SearchBy";
            cmbPublishers_SearchBy.Size = new Size(193, 29);
            cmbPublishers_SearchBy.TabIndex = 8;
            // 
            // btnPublishers_Buscar
            // 
            btnPublishers_Buscar.Font = new Font("Segoe UI", 12F);
            btnPublishers_Buscar.Location = new Point(957, 90);
            btnPublishers_Buscar.Name = "btnPublishers_Buscar";
            btnPublishers_Buscar.Size = new Size(100, 29);
            btnPublishers_Buscar.TabIndex = 9;
            btnPublishers_Buscar.Text = "Buscar";
            btnPublishers_Buscar.UseVisualStyleBackColor = true;
            btnPublishers_Buscar.Click += btnPublishers_Buscar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.Controls.Add(txtPublisher_Country);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(mskPublisher_State);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtPublisher_City);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtPublisher_name);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(mskPublishers_ID);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(btnPublishersEliminar);
            panel2.Controls.Add(btnPublishersModificar);
            panel2.Controls.Add(btnPublishersGuardar);
            panel2.Controls.Add(btnPublishersLimpiar);
            panel2.Location = new Point(10, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 753);
            panel2.TabIndex = 8;
            // 
            // txtPublisher_Country
            // 
            txtPublisher_Country.Location = new Point(31, 440);
            txtPublisher_Country.Name = "txtPublisher_Country";
            txtPublisher_Country.Size = new Size(332, 23);
            txtPublisher_Country.TabIndex = 32;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(31, 422);
            label17.Name = "label17";
            label17.Size = new Size(53, 15);
            label17.TabIndex = 31;
            label17.Text = "Country:";
            label17.TextAlign = ContentAlignment.TopCenter;
            // 
            // mskPublisher_State
            // 
            mskPublisher_State.Location = new Point(31, 374);
            mskPublisher_State.Mask = "AA";
            mskPublisher_State.Name = "mskPublisher_State";
            mskPublisher_State.Size = new Size(332, 23);
            mskPublisher_State.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(31, 356);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 29;
            label16.Text = "State:";
            // 
            // txtPublisher_City
            // 
            txtPublisher_City.Location = new Point(31, 300);
            txtPublisher_City.Name = "txtPublisher_City";
            txtPublisher_City.Size = new Size(332, 23);
            txtPublisher_City.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 282);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 27;
            label15.Text = "City:";
            // 
            // txtPublisher_name
            // 
            txtPublisher_name.Location = new Point(31, 230);
            txtPublisher_name.Name = "txtPublisher_name";
            txtPublisher_name.Size = new Size(332, 23);
            txtPublisher_name.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 212);
            label14.Name = "label14";
            label14.Size = new Size(102, 15);
            label14.TabIndex = 25;
            label14.Text = "Publisher's Name:";
            // 
            // mskPublishers_ID
            // 
            mskPublishers_ID.Location = new Point(31, 163);
            mskPublishers_ID.Mask = "9999";
            mskPublishers_ID.Name = "mskPublishers_ID";
            mskPublishers_ID.Size = new Size(332, 23);
            mskPublishers_ID.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 26);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 4;
            label10.Text = "Detalle Publishers";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 145);
            label13.Name = "label13";
            label13.Size = new Size(21, 15);
            label13.TabIndex = 4;
            label13.Text = "ID:";
            // 
            // btnPublishersEliminar
            // 
            btnPublishersEliminar.BackColor = Color.Maroon;
            btnPublishersEliminar.ForeColor = Color.White;
            btnPublishersEliminar.Location = new Point(41, 708);
            btnPublishersEliminar.Name = "btnPublishersEliminar";
            btnPublishersEliminar.Size = new Size(330, 23);
            btnPublishersEliminar.TabIndex = 24;
            btnPublishersEliminar.Text = "Eliminar";
            btnPublishersEliminar.UseVisualStyleBackColor = false;
            btnPublishersEliminar.Click += btnPublishersEliminar_Click;
            // 
            // btnPublishersModificar
            // 
            btnPublishersModificar.Font = new Font("Segoe UI", 9F);
            btnPublishersModificar.Location = new Point(41, 621);
            btnPublishersModificar.Name = "btnPublishersModificar";
            btnPublishersModificar.Size = new Size(330, 23);
            btnPublishersModificar.TabIndex = 21;
            btnPublishersModificar.Text = "Modificar";
            btnPublishersModificar.UseVisualStyleBackColor = true;
            btnPublishersModificar.Click += btnPublishersModificar_Click;
            // 
            // btnPublishersGuardar
            // 
            btnPublishersGuardar.BackColor = Color.Green;
            btnPublishersGuardar.ForeColor = Color.White;
            btnPublishersGuardar.Location = new Point(41, 650);
            btnPublishersGuardar.Name = "btnPublishersGuardar";
            btnPublishersGuardar.Size = new Size(330, 23);
            btnPublishersGuardar.TabIndex = 22;
            btnPublishersGuardar.Text = "Guardar";
            btnPublishersGuardar.UseVisualStyleBackColor = false;
            btnPublishersGuardar.Click += btnPublishersGuardar_Click;
            // 
            // btnPublishersLimpiar
            // 
            btnPublishersLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnPublishersLimpiar.ForeColor = Color.White;
            btnPublishersLimpiar.Location = new Point(41, 679);
            btnPublishersLimpiar.Name = "btnPublishersLimpiar";
            btnPublishersLimpiar.Size = new Size(330, 23);
            btnPublishersLimpiar.TabIndex = 23;
            btnPublishersLimpiar.Text = "Limpiar";
            btnPublishersLimpiar.UseVisualStyleBackColor = false;
            btnPublishersLimpiar.Click += btnPublishersLimpiar_Click;
            // 
            // dgvPublishers
            // 
            dgvPublishers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPublishers.Location = new Point(448, 181);
            dgvPublishers.Name = "dgvPublishers";
            dgvPublishers.Size = new Size(1180, 581);
            dgvPublishers.TabIndex = 7;
            dgvPublishers.CellContentClick += dgvPublishers_CellContentClick;
            // 
            // frmPublishers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 775);
            Controls.Add(panel13);
            Controls.Add(panel2);
            Controls.Add(dgvPublishers);
            Name = "frmPublishers";
            Text = "Form1";
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel13;
        private Button btnPublishers_Resetear;
        private Label label18;
        private TextBox txtPublishers_Buscar;
        private Label label19;
        private ComboBox cmbPublishers_SearchBy;
        private Button btnPublishers_Buscar;
        private Panel panel2;
        private TextBox txtPublisher_Country;
        private Label label17;
        private MaskedTextBox mskPublisher_State;
        private Label label16;
        private TextBox txtPublisher_City;
        private Label label15;
        private TextBox txtPublisher_name;
        private Label label14;
        private MaskedTextBox mskPublishers_ID;
        private Label label10;
        private Label label13;
        private Button btnPublishersEliminar;
        private Button btnPublishersModificar;
        private Button btnPublishersGuardar;
        private Button btnPublishersLimpiar;
        private DataGridView dgvPublishers;
    }
}