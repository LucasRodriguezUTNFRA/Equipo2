using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketek
{
    public partial class Vista1 : Form
    {
        public Vista1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SistemaDeEntradas.LogearUsuario(txb_usuario.Text, txb_contrasenia.Text))
            {
                if(SistemaDeEntradas.NombreUsuario.GetType() == typeof(Empleado)){
                    
                    FrmMenuEmpleado form = new FrmMenuEmpleado();
                    form.Show();

                }
                else{
                    if (SistemaDeEntradas.NombreUsuario.GetType() == typeof(Cliente))
                    {

                    }

                }
            }
        }
    }
}
