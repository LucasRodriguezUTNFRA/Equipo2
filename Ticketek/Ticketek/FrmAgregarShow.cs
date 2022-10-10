using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ticketek
{
    public partial class FrmAgregarShow : Form
    {
        public Show showCargado;

        public FrmAgregarShow()
        {
            InitializeComponent();
        }

        private void FrmAgregarShow_Load(object sender, EventArgs e)
        {
            cmb_ListaEstadios.DataSource = SistemaDeEntradas.ListaEstadios;
        }

        private void btn_AgregarShow_Click(object sender, EventArgs e)
        {
            showCargado = new Show(new Artista(txb_NombreArtista.Text), (Estadio)cmb_ListaEstadios.SelectedItem, dateTimePicker1.Value, (int)nud_Duracion.Value, (int)nud_PorcentajeVip.Value);
            this.DialogResult = DialogResult.OK;
                  
        }
    }
}
