namespace _2024_11_02_TopAva_Pubs
{
    partial class frmPubInfo
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
            btnImagen = new Button();
            txtPrInfo = new TextBox();
            pictureBox = new PictureBox();
            cmbPubId = new ComboBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel19 = new Panel();
            btn_Resetear = new Button();
            label7 = new Label();
            btn_Buscar = new Button();
            label19 = new Label();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            dgvPubInfo = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPubInfo).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 255, 255);
            panel8.Controls.Add(btnImagen);
            panel8.Controls.Add(txtPrInfo);
            panel8.Controls.Add(pictureBox);
            panel8.Controls.Add(cmbPubId);
            panel8.Controls.Add(btnEliminar);
            panel8.Controls.Add(btnModificar);
            panel8.Controls.Add(btnGuardar);
            panel8.Controls.Add(btnLimpiar);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(509, 520);
            panel8.TabIndex = 9;
            panel8.Paint += panel8_Paint;
            // 
            // btnImagen
            // 
            btnImagen.Location = new Point(242, 163);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new Size(75, 23);
            btnImagen.TabIndex = 48;
            btnImagen.Text = "Seleccionar";
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // txtPrInfo
            // 
            txtPrInfo.Location = new Point(6, 228);
            txtPrInfo.Multiline = true;
            txtPrInfo.Name = "txtPrInfo";
            txtPrInfo.Size = new Size(500, 147);
            txtPrInfo.TabIndex = 47;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(239, 28);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(267, 124);
            pictureBox.TabIndex = 46;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox1_Click;
            // 
            // cmbPubId
            // 
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Location = new Point(88, 68);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(121, 23);
            cmbPubId.TabIndex = 45;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(88, 468);
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
            btnModificar.Location = new Point(88, 381);
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
            btnGuardar.Location = new Point(88, 410);
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
            btnLimpiar.Location = new Point(88, 439);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 199);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Publisher_info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Publisher_Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 2);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Logo";
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
            // dgvPubInfo
            // 
            dgvPubInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPubInfo.Location = new Point(527, 199);
            dgvPubInfo.Name = "dgvPubInfo";
            dgvPubInfo.Size = new Size(494, 333);
            dgvPubInfo.TabIndex = 41;
            dgvPubInfo.CellClick += dgvPubInfo_CellClick;
            // 
            // frmPubInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 648);
            Controls.Add(dgvPubInfo);
            Controls.Add(panel19);
            Controls.Add(panel8);
            Name = "frmPubInfo";
            Text = "frmPubInfo";
            Load += frmPubInfo_Load;
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPubInfo).EndInit();
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
        private Label label1;
        private Panel panel19;
        private Button btn_Resetear;
        private Label label7;
        private Button btn_Buscar;
        private Label label19;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
        private DataGridView dgvPubInfo;
        private PictureBox pictureBox;
        private ComboBox cmbPubId;
        private TextBox txtPrInfo;
        private Button btnImagen;
    }
}