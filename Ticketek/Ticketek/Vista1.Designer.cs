namespace Ticketek
{
    partial class Vista1
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
            this.btn_login = new System.Windows.Forms.Button();
            this.txb_contrasenia = new System.Windows.Forms.TextBox();
            this.txb_usuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(486, 520);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(170, 92);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txb_contrasenia
            // 
            this.txb_contrasenia.Location = new System.Drawing.Point(374, 348);
            this.txb_contrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_contrasenia.Name = "txb_contrasenia";
            this.txb_contrasenia.PasswordChar = '*';
            this.txb_contrasenia.PlaceholderText = "Contraseña";
            this.txb_contrasenia.Size = new System.Drawing.Size(394, 31);
            this.txb_contrasenia.TabIndex = 4;
            this.txb_contrasenia.UseSystemPasswordChar = true;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Location = new System.Drawing.Point(374, 190);
            this.txb_usuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PlaceholderText = "Usuario";
            this.txb_usuario.Size = new System.Drawing.Size(394, 31);
            this.txb_usuario.TabIndex = 3;
            // 
            // Vista1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_contrasenia);
            this.Controls.Add(this.txb_usuario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vista1";
            this.Text = "Vista1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txb_contrasenia;
        private System.Windows.Forms.TextBox txb_usuario;
    }
}