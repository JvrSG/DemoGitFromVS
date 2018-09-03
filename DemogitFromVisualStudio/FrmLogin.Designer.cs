namespace DemogitFromVisualStudio
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIniciarSecion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(55, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(55, 121);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(55, 152);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(198, 20);
            this.txtContra.TabIndex = 3;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // btnIniciarSecion
            // 
            this.btnIniciarSecion.Location = new System.Drawing.Point(73, 202);
            this.btnIniciarSecion.Name = "btnIniciarSecion";
            this.btnIniciarSecion.Size = new System.Drawing.Size(147, 23);
            this.btnIniciarSecion.TabIndex = 4;
            this.btnIniciarSecion.Text = "Iniciar sesion";
            this.btnIniciarSecion.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnIniciarSecion);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Text = "Inicio de sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIniciarSecion;
    }
}