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
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            txtHoraAmanecer.Enabled = false;
            txtHoraMaxTemp.Enabled = false;
            txtHoraOcaso.Enabled = false;
            txtTempAmanecer.Enabled = false;
            txtTempMax.Enabled = false;
            txtTempOcaso.Enabled = false;
        }

        private void btnLookFor_Click(object sender, EventArgs e)
        {
            txtHoraAmanecer.Enabled = true;
            txtHoraMaxTemp.Enabled = true;
            txtHoraOcaso.Enabled = true;
            txtTempAmanecer.Enabled = true;
            txtTempMax.Enabled = true;
            txtTempOcaso.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
