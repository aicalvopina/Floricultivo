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
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            txtHoraAmanecer.Enabled = false;
            txtHoraMaxTemp.Enabled = false;
            txtHoraOcaso.Enabled = false;
            txtTempAmanecer.Enabled = false;
            txtTempMax.Enabled = false;
            txtTempOcaso.Enabled = false;
        }

        private void btnConnectDB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (flag == 1) { MessageBox.Show("Esta seguro de eliminar este registro"); }
            else{ }

        }
    }
}
