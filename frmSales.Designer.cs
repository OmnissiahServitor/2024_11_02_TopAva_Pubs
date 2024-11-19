namespace _2024_11_02_TopAva_Pubs
{
    partial class frmSales
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
            panel17 = new Panel();
            panel6 = new Panel();
            dgvSales = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbStores_ID = new ComboBox();
            txtOrderNumber = new TextBox();
            dtpOrder_Date = new DateTimePicker();
            numQuantity = new NumericUpDown();
            txtPayterms = new TextBox();
            cmbTitle_ID = new ComboBox();
            label7 = new Label();
            btn_Resetear = new Button();
            txt_Buscar = new TextBox();
            cmb_SearchBy = new ComboBox();
            btn_Buscar = new Button();
            label19 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            panel17.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(255, 224, 192);
            panel17.Controls.Add(btn_Resetear);
            panel17.Controls.Add(label7);
            panel17.Controls.Add(txt_Buscar);
            panel17.Controls.Add(cmb_SearchBy);
            panel17.Controls.Add(label19);
            panel17.Controls.Add(btn_Buscar);
            panel17.Location = new Point(452, 12);
            panel17.Name = "panel17";
            panel17.Size = new Size(891, 151);
            panel17.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 255, 255);
            panel6.Controls.Add(btnEliminar);
            panel6.Controls.Add(cmbTitle_ID);
            panel6.Controls.Add(btnModificar);
            panel6.Controls.Add(btnGuardar);
            panel6.Controls.Add(txtPayterms);
            panel6.Controls.Add(btnLimpiar);
            panel6.Controls.Add(numQuantity);
            panel6.Controls.Add(dtpOrder_Date);
            panel6.Controls.Add(txtOrderNumber);
            panel6.Controls.Add(cmbStores_ID);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(14, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(414, 544);
            panel6.TabIndex = 8;
            // 
            // dgvSales
            // 
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Location = new Point(452, 184);
            dgvSales.Name = "dgvSales";
            dgvSales.Size = new Size(891, 372);
            dgvSales.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 90);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Store's ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 125);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Order's number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 168);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 2;
            label3.Text = "Order's date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 200);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 234);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay terms:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 269);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Title's ID:";
            // 
            // cmbStores_ID
            // 
            cmbStores_ID.FormattingEnabled = true;
            cmbStores_ID.Location = new Point(163, 87);
            cmbStores_ID.Name = "cmbStores_ID";
            cmbStores_ID.Size = new Size(201, 23);
            cmbStores_ID.TabIndex = 10;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(163, 122);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.Size = new Size(201, 23);
            txtOrderNumber.TabIndex = 11;
            // 
            // dtpOrder_Date
            // 
            dtpOrder_Date.CustomFormat = "yyyy-MM-dd";
            dtpOrder_Date.Format = DateTimePickerFormat.Short;
            dtpOrder_Date.Location = new Point(163, 162);
            dtpOrder_Date.Name = "dtpOrder_Date";
            dtpOrder_Date.Size = new Size(201, 23);
            dtpOrder_Date.TabIndex = 23;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(163, 198);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(201, 23);
            numQuantity.TabIndex = 24;
            // 
            // txtPayterms
            // 
            txtPayterms.Location = new Point(163, 231);
            txtPayterms.Name = "txtPayterms";
            txtPayterms.Size = new Size(201, 23);
            txtPayterms.TabIndex = 25;
            // 
            // cmbTitle_ID
            // 
            cmbTitle_ID.FormattingEnabled = true;
            cmbTitle_ID.Location = new Point(163, 266);
            cmbTitle_ID.Name = "cmbTitle_ID";
            cmbTitle_ID.Size = new Size(201, 23);
            cmbTitle_ID.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 31);
            label7.Name = "label7";
            label7.Size = new Size(159, 45);
            label7.TabIndex = 30;
            label7.Text = "Busqueda";
            // 
            // btn_Resetear
            // 
            btn_Resetear.Font = new Font("Segoe UI", 12F);
            btn_Resetear.Location = new Point(729, 87);
            btn_Resetear.Name = "btn_Resetear";
            btn_Resetear.Size = new Size(100, 29);
            btn_Resetear.TabIndex = 27;
            btn_Resetear.Text = "Resetear";
            btn_Resetear.UseVisualStyleBackColor = true;
            btn_Resetear.Click += btn_Resetear_Click;
            // 
            // txt_Buscar
            // 
            txt_Buscar.Font = new Font("Segoe UI", 12F);
            txt_Buscar.Location = new Point(400, 90);
            txt_Buscar.Name = "txt_Buscar";
            txt_Buscar.Size = new Size(201, 29);
            txt_Buscar.TabIndex = 26;
            // 
            // cmb_SearchBy
            // 
            cmb_SearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_SearchBy.FormattingEnabled = true;
            cmb_SearchBy.Location = new Point(190, 89);
            cmb_SearchBy.Name = "cmb_SearchBy";
            cmb_SearchBy.Size = new Size(193, 29);
            cmb_SearchBy.TabIndex = 24;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Font = new Font("Segoe UI", 12F);
            btn_Buscar.Location = new Point(623, 88);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(100, 29);
            btn_Buscar.TabIndex = 25;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(97, 92);
            label19.Name = "label19";
            label19.Size = new Size(87, 21);
            label19.TabIndex = 23;
            label19.Text = "Buscar por:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Maroon;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(43, 476);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(330, 23);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 9F);
            btnModificar.Location = new Point(43, 389);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(330, 23);
            btnModificar.TabIndex = 33;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(43, 418);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(330, 23);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(0, 0, 192);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(43, 447);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(330, 23);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 568);
            Controls.Add(panel17);
            Controls.Add(panel6);
            Controls.Add(dgvSales);
            Name = "frmSales";
            Text = "Sale's Table";
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel17;
        private Panel panel6;
        private DataGridView dgvSales;
        private ComboBox cmbStores_ID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOrderNumber;
        private ComboBox cmbTitle_ID;
        private TextBox txtPayterms;
        private NumericUpDown numQuantity;
        private DateTimePicker dtpOrder_Date;
        private Label label7;
        private Button btn_Resetear;
        private TextBox txt_Buscar;
        private ComboBox cmb_SearchBy;
        private Label label19;
        private Button btn_Buscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}