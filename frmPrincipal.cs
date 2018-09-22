using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Floricultivo.Capa_de_control;

namespace Floricultivo
{
    public partial class frmMain : Form
    {
        frmInformacion form2 = new frmInformacion();
        GradoDia dia;
        TemperaturaHora tmepHora;
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
            double horaAmanecer = Convert.ToDouble(txtboxHoraAmanecer.Text);
            double temperaturaAmanecer = Convert.ToDouble(txtboxTempAmanecer.Text);
            double temperaturaMaxima = temperaturaAmanecer + 21;
            DateTime diasAux = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
            dia = new GradoDia(temperaturaMaxima, temperaturaAmanecer, Convert.ToDouble(txtboxTempBase.Text));
            dia.crearDia(horaAmanecer, temperaturaAmanecer, diasAux);
            this.tmepHora = new TemperaturaHora(diasAux);
            this.tmepHora.guardarTemperaturas(diasAux);
            List<double> gradosHora = this.dia.gradosHoraCalculo(diasAux);

            this.dgvDatos.ColumnCount = 2;
            this.dgvDatos.ColumnHeadersVisible = true;
            this.dgvDatos.Columns[0].Name = "FECHA(dd/mm/aaaa)";
            this.dgvDatos.Columns[0].Width = 120;
            this.dgvDatos.Columns[1].Name = "GRADO HORA (F)";
            this.dgvDatos.Columns[1].Width = 120;

            for (int i = 0 ; i < gradosHora.Count; i++)
            {
                this.dgvDatos.Rows.Add(i+":00:00", gradosHora[i]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            float x1 = 0.1;
            float x2 = 0.1;
            float x3 = 0.1;
            float x4 = 0.1;
            float x5 = 0.1;
            float x6 = 0.1;
            float x7 = 0.1;
            float x8 = 0.1;
            float x9 = 0.1;
            float x10 = 0.1;
            float x11 = 0.1;
            float x12 = 0.1;
        }

    }
}
