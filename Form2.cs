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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.AutoSize = false;
            label1.Size = new Size(198, 60);
            label1.Text = "El siguiente programa calcula los grados dia de un cultivo mediante el uso de datos obtenidos de sensores.";
        }

    }
}
