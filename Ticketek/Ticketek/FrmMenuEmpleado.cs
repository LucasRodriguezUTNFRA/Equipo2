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
    public partial class FrmMenuEmpleado : Form
    {
        public FrmMenuEmpleado()
        {
            InitializeComponent();
        }

        private void FrmMenuEmpleado_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btn_AgregarShow_Click(object sender, EventArgs e)
        {
            FrmAgregarShow formAgregar = new FrmAgregarShow();

            if(formAgregar.ShowDialog()== DialogResult.OK)
            {
                SistemaDeEntradas.ListaShows.Add(formAgregar.showCargado);
                ActualizarDataGrid();
            }

        }

        private void ActualizarDataGrid()
        {
            dgv_listadoShows.DataSource = null;
            dgv_listadoShows.DataSource = SistemaDeEntradas.ListaShows;
        }
    }
}
