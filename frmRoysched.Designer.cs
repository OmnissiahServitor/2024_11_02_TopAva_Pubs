namespace _2024_11_02_TopAva_Pubs
{
    partial class frmRoysched
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
            panel18 = new Panel();
            btn_Resetear = new Button();
            label7 = new Label();
            btn_Buscar = new Button();
            txt_Buscar = new TextBox();
            label19 = new Label();
            cmb_SearchBy = new ComboBox();
            panel7 = new Panel();
            btnEliminar = new Button();
            numLowRange = new NumericUpDown();
            btnModificar = new Button();
            btnGuardar = new Button();
            numHigh_Range = new NumericUpDown();
            btnLimpiar = new Button();
            numRoyalty = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cmbTitle_ID = new ComboBox();
            label2 = new Label();
            txtRoysched_ID = new TextBox();
            label1 = new Label();
            dgvRoysched = new DataGridView();
            panel18.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLowRange).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHigh_Range).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoyalty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoysched).BeginInit();
            SuspendLayout();
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(255, 224, 192);
            panel18.Controls.Add(btn_Resetear);
            panel18.Controls.Add(label7);
            panel18.Controls.Add(btn_Buscar);
            panel18.Controls.Add(txt_Buscar);
            panel18.Controls.Add(label19);
            panel18.Controls.Add(cmb_SearchBy);
            panel18.Location = new Point(445, 9);
            panel18.Name = "panel18";
            panel18.Size = new Size(915, 151);
            panel18.TabIndex = 9;
            // 
            // btn_Resetear
            // 
            btn_Resetear.Font = new Font("Segoe UI", 12F);
            btn_Resetear.Location = new Point(749, 90);
            btn_Resetear.Name = "btn_Resetear";
            btn_Resetear.Size = new Size(100, 29);
            btn_Resetear.TabIndex = 35;
            btn_Resetear.Text = "Resetear";
            btn_Resetear.UseVisualStyleBackColor = true;
            btn_Resetear.Click += btn_Resetear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 34);
            label7.Name = "label7";
            label7.Size = new Size(159, 45);
            label7.TabIndex = 36;
            label7.Text = "Busqueda";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F);
            btn_Buscar.Location = new Point(643, 91);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(100, 29);
            btn_Buscar.TabIndex = 33;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Font = new Font("Segoe UI", 12F);
            txt_Buscar.Location = new Point(420, 93);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(201, 29);
            txt_Buscar.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(117, 95);
            label19.Name = "label19";
            label19.Size = new Size(87, 21);
            label19.TabIndex = 31;
            label19.Text = "Buscar por:";
            // 
            // cmb_SearchBy
            // 
            cmb_SearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_SearchBy.FormattingEnabled = true;
            cmb_SearchBy.Location = new Point(210, 92);
            cmb_SearchBy.Name = "cmb_SearchBy";
            cmb_SearchBy.Size = new Size(193, 29);
            cmb_SearchBy.TabIndex = 32;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 255, 255);
            panel7.Controls.Add(btnEliminar);
            panel7.Controls.Add(numLowRange);
            panel7.Controls.Add(btnModificar);
            panel7.Controls.Add(btnGuardar);
            panel7.Controls.Add(numHigh_Range);
            panel7.Controls.Add(btnLimpiar);
            panel7.Controls.Add(numRoyalty);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(cmbTitle_ID);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(txtRoysched_ID);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(7, 9);
            panel7.Name = "panel7";
            panel7.Size = new Size(414, 543);
            panel7.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(44, 390);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(330, 23);
            btnEliminar.TabIndex = 40;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // numLowRange
            // 
            numLowRange.Location = new Point(146, 172);
            numLowRange.Maximum = new decimal(new int[] { 45000, 0, 0, 0 });
            numLowRange.Name = "numLowRange";
            numLowRange.Size = new Size(209, 23);
            numLowRange.TabIndex = 9;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.Location = new Point(44, 303);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(330, 23);
            btnModificar.TabIndex = 37;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(44, 332);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numHigh_Range
            // 
            numHigh_Range.Location = new Point(146, 201);
            numHigh_Range.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numHigh_Range.Name = "numHigh_Range";
            numHigh_Range.Size = new Size(209, 23);
            numHigh_Range.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(44, 361);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 39;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // numRoyalty
            // 
            numRoyalty.Location = new Point(146, 230);
            numRoyalty.Name = "numRoyalty";
            numRoyalty.Size = new Size(209, 23);
            numRoyalty.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 232);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 6;
            label5.Text = "Royalty:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 200);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 5;
            label4.Text = "High Range:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 171);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Low Range:";
            // 
            // cmbTitle_ID
            // 
            cmbTitle_ID.FormattingEnabled = true;
            cmbTitle_ID.Location = new Point(146, 143);
            cmbTitle_ID.Name = "cmbTitle_ID";
            cmbTitle_ID.Size = new Size(209, 23);
            cmbTitle_ID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 143);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Title's ID:";
            // 
            // txtRoysched_ID
            // 
            txtRoysched_ID.Location = new Point(146, 114);
            txtRoysched_ID.Name = "txtRoysched_ID";
            txtRoysched_ID.Size = new Size(209, 23);
            txtRoysched_ID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 114);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Roysched's ID:";
            // 
            // dgvRoysched
            // 
            dgvRoysched.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoysched.Location = new Point(445, 181);
            dgvRoysched.Name = "dgvRoysched";
            dgvRoysched.Size = new Size(915, 371);
            dgvRoysched.TabIndex = 7;
            // 
            // frmRoysched
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 564);
            Controls.Add(panel18);
            Controls.Add(panel7);
            Controls.Add(dgvRoysched);
            Name = "frmRoysched";
            Text = "Roysched Table";
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLowRange).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHigh_Range).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoyalty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoysched).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel18;
        private Panel panel7;
        private DataGridView dgvRoysched;
        private Label label4;
        private Label label3;
        private ComboBox cmbTitle_ID;
        private Label label2;
        private TextBox txtRoysched_ID;
        private Label label1;
        private NumericUpDown numLowRange;
        private NumericUpDown numHigh_Range;
        private NumericUpDown numRoyalty;
        private Label label5;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btn_Resetear;
        private Label label7;
        private Button btn_Buscar;
        private TextBox txt_Buscar;
        private Label label19;
        private ComboBox cmb_SearchBy;
    }
}