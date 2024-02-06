namespace Forms
{
    partial class FormDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            btnSaludar = new Button();
            lblMensajeNombre = new Label();
            cbx_materias = new ComboBox();
            lblMateria = new Label();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(26, 45);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(211, 27);
            tbNombre.TabIndex = 0;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(277, 45);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(211, 27);
            tbApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(26, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(277, 22);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // btnSaludar
            // 
            btnSaludar.BackColor = SystemColors.ButtonFace;
            btnSaludar.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaludar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnSaludar.FlatAppearance.BorderSize = 2;
            btnSaludar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnSaludar.FlatStyle = FlatStyle.Flat;
            btnSaludar.Location = new Point(277, 187);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(211, 31);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseMnemonic = false;
            btnSaludar.UseVisualStyleBackColor = false;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblMensajeNombre
            // 
            lblMensajeNombre.AutoSize = true;
            lblMensajeNombre.ForeColor = Color.Red;
            lblMensajeNombre.Location = new Point(26, 75);
            lblMensajeNombre.Name = "lblMensajeNombre";
            lblMensajeNombre.Size = new Size(0, 20);
            lblMensajeNombre.TabIndex = 5;
            // 
            // cbx_materias
            // 
            cbx_materias.BackColor = SystemColors.ControlLightLight;
            cbx_materias.DisplayMember = "xv xc";
            cbx_materias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_materias.FlatStyle = FlatStyle.Popup;
            cbx_materias.FormattingEnabled = true;
            cbx_materias.ImeMode = ImeMode.NoControl;
            cbx_materias.Location = new Point(26, 141);
            cbx_materias.Name = "cbx_materias";
            cbx_materias.Size = new Size(462, 28);
            cbx_materias.TabIndex = 6;
            cbx_materias.ValueMember = "xv xc";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMateria.Location = new Point(26, 118);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(124, 20);
            lblMateria.TabIndex = 7;
            lblMateria.Text = "Materia Favorita";
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 235);
            Controls.Add(lblMateria);
            Controls.Add(cbx_materias);
            Controls.Add(lblMensajeNombre);
            Controls.Add(btnSaludar);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDatos";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            Load += FormDatos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbApellido;
        private Label lblNombre;
        private Label lblApellido;
        private Button btnSaludar;
        private Label lblMensajeNombre;
        private ComboBox cbx_materias;
        private Label lblMateria;
    }
}
