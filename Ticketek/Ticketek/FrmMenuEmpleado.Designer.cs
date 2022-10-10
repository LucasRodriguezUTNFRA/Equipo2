
namespace Ticketek
{
    partial class FrmMenuEmpleado
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
            this.dgv_listadoShows = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoShows)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AgregarShow
            // 
            this.btn_AgregarShow.Location = new System.Drawing.Point(37, 49);
            this.btn_AgregarShow.Name = "btn_AgregarShow";
            this.btn_AgregarShow.Size = new System.Drawing.Size(90, 23);
            this.btn_AgregarShow.TabIndex = 0;
            this.btn_AgregarShow.Text = "Agregar show";
            this.btn_AgregarShow.UseVisualStyleBackColor = true;
            this.btn_AgregarShow.Click += new System.EventHandler(this.btn_AgregarShow_Click);
            // 
            // dgv_listadoShows
            // 
            this.dgv_listadoShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listadoShows.Location = new System.Drawing.Point(37, 88);
            this.dgv_listadoShows.Name = "dgv_listadoShows";
            this.dgv_listadoShows.RowTemplate.Height = 25;
            this.dgv_listadoShows.Size = new System.Drawing.Size(352, 201);
            this.dgv_listadoShows.TabIndex = 2;
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_listadoShows);
            this.Controls.Add(this.btn_AgregarShow);
            this.Name = "FrmMenuEmpleado";
            this.Text = "FrmMenuEmpleado";
            this.Load += new System.EventHandler(this.FrmMenuEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listadoShows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarShow;
        private System.Windows.Forms.DataGridView dgv_listadoShows;
    }
}