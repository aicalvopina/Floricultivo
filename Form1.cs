﻿using System;
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
        Form2 form2 = new Form2();
        public frmMain()
        {
            InitializeComponent();
        }

        private void mOptionInformation_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola perros");
            form2.Show();
        }

    }
}
