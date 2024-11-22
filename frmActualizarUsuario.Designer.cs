namespace _2024_11_02_TopAva_Pubs
{
    partial class frmActualizarUsuario
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
            labUsuario = new Label();
            label3 = new Label();
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            btn_Actualizar = new Button();
            SuspendLayout();
            // 
            // labUsuario
            // 
            labUsuario.AutoSize = true;
            labUsuario.Font = new Font("Segoe UI", 12F);
            labUsuario.Location = new Point(51, 51);
            labUsuario.Name = "labUsuario";
            labUsuario.Size = new Size(89, 21);
            labUsuario.TabIndex = 9;
            labUsuario.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(53, 101);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 10;
            label3.Text = "Last Name:";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(160, 53);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(258, 23);
            txt_FirstName.TabIndex = 11;
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(160, 103);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(258, 23);
            txt_LastName.TabIndex = 12;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(252, 171);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(166, 23);
            btn_Actualizar.TabIndex = 13;
            btn_Actualizar.Text = "Actualizar";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // frmActualizarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 217);
            Controls.Add(btn_Actualizar);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(labUsuario);
            Controls.Add(label3);
            Name = "frmActualizarUsuario";
            Text = "Actualizar Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labUsuario;
        private Label label3;
        private TextBox txt_FirstName;
        private TextBox txt_LastName;
        private Button btn_Actualizar;
    }
}