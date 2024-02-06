namespace Forms
{
    partial class FormSaludo
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
            lblSaludo = new Label();
            lblNombreSaludo = new Label();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            lblSaludo.Location = new Point(51, 48);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(289, 35);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡Hola, Windows Forms!";
            // 
            // lblNombreSaludo
            // 
            lblNombreSaludo.AutoSize = true;
            lblNombreSaludo.Font = new Font("Segoe UI", 12F);
            lblNombreSaludo.Location = new Point(51, 126);
            lblNombreSaludo.Name = "lblNombreSaludo";
            lblNombreSaludo.Size = new Size(65, 28);
            lblNombreSaludo.TabIndex = 1;
            lblNombreSaludo.Text = "label2";
            // 
            // FormSaludo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 205);
            Controls.Add(lblNombreSaludo);
            Controls.Add(lblSaludo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSaludo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            Load += FormSaludo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Label lblNombreSaludo;
    }
}