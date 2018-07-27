using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floricultivo
{
    public partial class frmMain : Form
    {
        frmInformacion form2 = new frmInformacion();
        public frmMain()
        {
            InitializeComponent();
        }

        private void mOptionInformation_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void mOptionUpdate_Click(object sender, EventArgs e)
        {
            frmEditar editar = new frmEditar();
            editar.Show();
        }

        private void mOptionDelete_Click(object sender, EventArgs e)
        {
            frmEliminar eliminar = new frmEliminar();
            eliminar.Show();
        }

        private void mOptionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mOptionNew_Click(object sender, EventArgs e)
        {
            dgvDatos.DataSource = null;
            dtpDate.Value = DateTime.Today.AddDays(-1);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }

    }
}
