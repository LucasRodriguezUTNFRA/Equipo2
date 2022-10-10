
namespace Ticketek
{
    partial class FrmAgregarShow
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
            this.btn_AgregarShow = new System.Windows.Forms.Button();
            this.txb_NombreArtista = new System.Windows.Forms.TextBox();
            this.cmb_ListaEstadios = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nud_Duracion = new System.Windows.Forms.NumericUpDown();
            this.nud_PorcentajeVip = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Duracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PorcentajeVip)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarShow
            // 
            this.btn_AgregarShow.Location = new System.Drawing.Point(95, 238);
            this.btn_AgregarShow.Name = "btn_AgregarShow";
            this.btn_AgregarShow.Size = new System.Drawing.Size(121, 23);
            this.btn_AgregarShow.TabIndex = 0;
            this.btn_AgregarShow.Text = "Agregar show";
            this.btn_AgregarShow.UseVisualStyleBackColor = true;
            this.btn_AgregarShow.Click += new System.EventHandler(this.btn_AgregarShow_Click);
            // 
            // txb_NombreArtista
            // 
            this.txb_NombreArtista.Location = new System.Drawing.Point(95, 33);
            this.txb_NombreArtista.Name = "txb_NombreArtista";
            this.txb_NombreArtista.PlaceholderText = "artista";
            this.txb_NombreArtista.Size = new System.Drawing.Size(100, 23);
            this.txb_NombreArtista.TabIndex = 1;
            // 
            // cmb_ListaEstadios
            // 
            this.cmb_ListaEstadios.FormattingEnabled = true;
            this.cmb_ListaEstadios.Location = new System.Drawing.Point(95, 83);
            this.cmb_ListaEstadios.Name = "cmb_ListaEstadios";
            this.cmb_ListaEstadios.Size = new System.Drawing.Size(121, 23);
            this.cmb_ListaEstadios.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // nud_Duracion
            // 
            this.nud_Duracion.Location = new System.Drawing.Point(96, 164);
            this.nud_Duracion.Name = "nud_Duracion";
            this.nud_Duracion.Size = new System.Drawing.Size(120, 23);
            this.nud_Duracion.TabIndex = 6;
            // 
            // nud_PorcentajeVip
            // 
            this.nud_PorcentajeVip.Location = new System.Drawing.Point(95, 193);
            this.nud_PorcentajeVip.Name = "nud_PorcentajeVip";
            this.nud_PorcentajeVip.Size = new System.Drawing.Size(120, 23);
            this.nud_PorcentajeVip.TabIndex = 7;
            // 
            // FrmAgregarShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 310);
            this.Controls.Add(this.nud_PorcentajeVip);
            this.Controls.Add(this.nud_Duracion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_ListaEstadios);
            this.Controls.Add(this.txb_NombreArtista);
            this.Controls.Add(this.btn_AgregarShow);
            this.Name = "FrmAgregarShow";
            this.Text = "FrmAgregarShow";
            this.Load += new System.EventHandler(this.FrmAgregarShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Duracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PorcentajeVip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarShow;
        private System.Windows.Forms.TextBox txb_NombreArtista;
        private System.Windows.Forms.ComboBox cmb_ListaEstadios;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nud_Duracion;
        private System.Windows.Forms.NumericUpDown nud_PorcentajeVip;
    }
}