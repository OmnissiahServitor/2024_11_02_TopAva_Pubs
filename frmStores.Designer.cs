namespace _2024_11_02_TopAva_Pubs
{
    partial class frmStores
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
            MaskedTextBox mskStores_State;
            panel16 = new Panel();
            btn_Resetear = new Button();
            label8 = new Label();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            btn_Buscar = new Button();
            label19 = new Label();
            panel5 = new Panel();
            mskStores_ID = new MaskedTextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            mskStores_Zip = new MaskedTextBox();
            btnLimpiar = new Button();
            label7 = new Label();
            label6 = new Label();
            txtStores_City = new TextBox();
            label5 = new Label();
            txtStores_address = new TextBox();
            label4 = new Label();
            txtStores_name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvStores = new DataGridView();
            mskStores_State = new MaskedTextBox();
            panel16.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).BeginInit();
            SuspendLayout();
            // 
            // mskStores_State
            // 
            mskStores_State.Location = new Point(165, 271);
            mskStores_State.Mask = "LL";
            mskStores_State.Name = "mskStores_State";
            mskStores_State.Size = new Size(196, 23);
            mskStores_State.TabIndex = 13;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(255, 224, 192);
            panel16.Controls.Add(btn_Resetear);
            panel16.Controls.Add(label8);
            panel16.Controls.Add(txt_Buscar);
            panel16.Controls.Add(cmb_SearchBy);
            panel16.Controls.Add(btn_Buscar);
            panel16.Controls.Add(label19);
            panel16.Location = new Point(442, 14);
            panel16.Name = "panel16";
            panel16.Size = new Size(825, 151);
            panel16.TabIndex = 9;
            // 
            // btn_Resetear
            // 
            btn_Resetear.Font = new Font("Segoe UI", 12F);
            btn_Resetear.Location = new Point(708, 90);
            btn_Resetear.Name = "btn_Resetear";
            btn_Resetear.Size = new Size(100, 29);
            btn_Resetear.TabIndex = 22;
            btn_Resetear.Text = "Resetear";
            btn_Resetear.UseVisualStyleBackColor = true;
            btn_Resetear.Click += btn_Resetear_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 6);
            label8.Name = "label8";
            label8.Size = new Size(295, 50);
            label8.TabIndex = 33;
            label8.Text = "Busqueda Stores";
            // 
            // txt_Buscar
            // 
            txt_Buscar.Font = new Font("Segoe UI", 12F);
            txt_Buscar.Location = new Point(368, 91);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(201, 29);
            txt_Buscar.TabIndex = 21;
            // 
            // cmb_SearchBy
            // 
            cmb_SearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_SearchBy.FormattingEnabled = true;
            cmb_SearchBy.Location = new Point(169, 92);
            cmb_SearchBy.Name = "cmb_SearchBy";
            cmb_SearchBy.Size = new Size(193, 29);
            cmb_SearchBy.TabIndex = 19;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F);
            btn_Buscar.Location = new Point(602, 91);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(100, 29);
            btn_Buscar.TabIndex = 20;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(76, 95);
            label19.Name = "label19";
            label19.Size = new Size(87, 21);
            label19.TabIndex = 18;
            label19.Text = "Buscar por:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 255);
            panel5.Controls.Add(mskStores_ID);
            panel5.Controls.Add(btnEliminar);
            panel5.Controls.Add(mskStores_State);
            panel5.Controls.Add(btnModificar);
            panel5.Controls.Add(btnGuardar);
            panel5.Controls.Add(mskStores_Zip);
            panel5.Controls.Add(btnLimpiar);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(txtStores_City);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(txtStores_address);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtStores_name);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(12, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(414, 550);
            panel5.TabIndex = 8;
            // 
            // mskStores_ID
            // 
            mskStores_ID.Location = new Point(165, 78);
            mskStores_ID.Mask = "9999";
            mskStores_ID.Name = "mskStores_ID";
            mskStores_ID.Size = new Size(196, 23);
            mskStores_ID.TabIndex = 33;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(46, 512);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(330, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.Location = new Point(46, 425);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(330, 23);
            btnModificar.TabIndex = 29;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(46, 454);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // mskStores_Zip
            // 
            mskStores_Zip.Location = new Point(165, 319);
            mskStores_Zip.Mask = "99999";
            mskStores_Zip.Name = "mskStores_Zip";
            mskStores_Zip.Size = new Size(196, 23);
            mskStores_Zip.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(46, 483);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 31;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(108, 322);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 11;
            label7.Text = "Zip:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 274);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "State:";
            // 
            // txtStores_City
            // 
            txtStores_City.Location = new Point(165, 222);
            txtStores_City.Name = "txtStores_City";
            txtStores_City.Size = new Size(196, 23);
            txtStores_City.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 225);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 7;
            label5.Text = "City:";
            // 
            // txtStores_address
            // 
            txtStores_address.Location = new Point(165, 169);
            txtStores_address.Name = "txtStores_address";
            txtStores_address.Size = new Size(196, 23);
            txtStores_address.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Store's address:";
            // 
            // txtStores_name
            // 
            txtStores_name.Location = new Point(165, 119);
            txtStores_name.Name = "txtStores_name";
            txtStores_name.Size = new Size(196, 23);
            txtStores_name.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 122);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "Store's name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 81);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Store's ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(248, 50);
            label1.TabIndex = 0;
            label1.Text = "Detalle Stores";
            // 
            // dgvStores
            // 
            dgvStores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStores.Location = new Point(442, 186);
            dgvStores.Name = "dgvStores";
            dgvStores.Size = new Size(825, 378);
            dgvStores.TabIndex = 7;
            // 
            // frmStores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 576);
            Controls.Add(panel16);
            Controls.Add(panel5);
            Controls.Add(dgvStores);
            Name = "frmStores";
            Text = "Store's Table";
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel16;
        private Panel panel5;
        private Label label2;
        private Label label1;
        private DataGridView dgvStores;
        private MaskedTextBox mskStores_State;
        private MaskedTextBox mskStores_Zip;
        private Label label7;
        private Label label6;
        private TextBox txtStores_City;
        private Label label5;
        private TextBox txtStores_address;
        private Label label4;
        private TextBox txtStores_name;
        private Label label3;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label8;
        private Button btn_Resetear;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
        private Button btn_Buscar;
        private Label label19;
        private MaskedTextBox mskStores_ID;
    }
}