namespace _2024_11_02_TopAva_Pubs
{
    partial class frmDiscounts
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
            panel19 = new Panel();
            btn_Resetear = new Button();
            label7 = new Label();
            btn_Buscar = new Button();
            label19 = new Label();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            panel8 = new Panel();
            btnEliminar = new Button();
            txt_DiscountPer = new TextBox();
            btnModificar = new Button();
            btnGuardar = new Button();
            num_HighQuantity = new NumericUpDown();
            btnLimpiar = new Button();
            num_LowQuantity = new NumericUpDown();
            cmbStore_ID = new ComboBox();
            txtType = new TextBox();
            txtDiscount_ID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDiscounts = new DataGridView();
            panel19.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_HighQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_LowQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).BeginInit();
            SuspendLayout();
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
            panel19.Location = new Point(444, 12);
            panel19.Name = "panel19";
            panel19.Size = new Size(494, 170);
            panel19.TabIndex = 9;
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
            btn_Resetear.Click += btn_Resetear_Click;
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
            btn_Buscar.Click += btn_Buscar_Click;
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
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(192, 255, 255);
            panel8.Controls.Add(btnEliminar);
            panel8.Controls.Add(txt_DiscountPer);
            panel8.Controls.Add(btnModificar);
            panel8.Controls.Add(btnGuardar);
            panel8.Controls.Add(num_HighQuantity);
            panel8.Controls.Add(btnLimpiar);
            panel8.Controls.Add(num_LowQuantity);
            panel8.Controls.Add(cmbStore_ID);
            panel8.Controls.Add(txtType);
            panel8.Controls.Add(txtDiscount_ID);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(414, 519);
            panel8.TabIndex = 8;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(46, 468);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(330, 23);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txt_DiscountPer
            // 
            txt_DiscountPer.Location = new Point(191, 255);
            txt_DiscountPer.Name = "txt_DiscountPer";
            txt_DiscountPer.Size = new Size(174, 23);
            txt_DiscountPer.TabIndex = 11;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.Location = new Point(46, 381);
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
            btnGuardar.Location = new Point(46, 410);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // num_HighQuantity
            // 
            num_HighQuantity.Location = new Point(191, 220);
            num_HighQuantity.Name = "num_HighQuantity";
            num_HighQuantity.Size = new Size(174, 23);
            num_HighQuantity.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(46, 439);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 43;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // num_LowQuantity
            // 
            num_LowQuantity.Location = new Point(191, 184);
            num_LowQuantity.Name = "num_LowQuantity";
            num_LowQuantity.Size = new Size(174, 23);
            num_LowQuantity.TabIndex = 9;
            // 
            // cmbStore_ID
            // 
            cmbStore_ID.FormattingEnabled = true;
            cmbStore_ID.Location = new Point(191, 147);
            cmbStore_ID.Name = "cmbStore_ID";
            cmbStore_ID.Size = new Size(174, 23);
            cmbStore_ID.TabIndex = 8;
            // 
            // txtType
            // 
            txtType.Location = new Point(191, 111);
            txtType.Name = "txtType";
            txtType.Size = new Size(174, 23);
            txtType.TabIndex = 7;
            // 
            // txtDiscount_ID
            // 
            txtDiscount_ID.Location = new Point(191, 75);
            txtDiscount_ID.Name = "txtDiscount_ID";
            txtDiscount_ID.Size = new Size(174, 23);
            txtDiscount_ID.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 258);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Discount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 222);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "High Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 186);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 3;
            label4.Text = "Low Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Store's ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 114);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Discount Type:";
            // 
            // dgvDiscounts
            // 
            dgvDiscounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscounts.Location = new Point(444, 198);
            dgvDiscounts.Name = "dgvDiscounts";
            dgvDiscounts.Size = new Size(494, 333);
            dgvDiscounts.TabIndex = 7;
            // 
            // frmDiscounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 543);
            Controls.Add(panel19);
            Controls.Add(panel8);
            Controls.Add(dgvDiscounts);
            Name = "frmDiscounts";
            Text = "Discounts Table";
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_HighQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_LowQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDiscounts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel19;
        private Panel panel8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvDiscounts;
        private Label label5;
        private Label label6;
        private NumericUpDown num_HighQuantity;
        private NumericUpDown num_LowQuantity;
        private ComboBox cmbStore_ID;
        private TextBox txtType;
        private TextBox txtDiscount_ID;
        private TextBox txt_DiscountPer;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label7;
        private Button btn_Resetear;
        private Button btn_Buscar;
        private Label label19;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
    }
}