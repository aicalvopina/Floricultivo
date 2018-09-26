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
using Floricultivo.Capa_de_DB;
using System.Windows.Forms.DataVisualization.Charting;

namespace Floricultivo
{
    public partial class frmMain : Form
    {
        frmInformacion form2 = new frmInformacion();
        GradoDia dia;
        DiaServicio servDia =  new DiaServicio();
        TemperaturaHora tmepHora;
        List<double> gradosHora;
        List<String> graficos;
        int numGraficos;
        int numDatos;
        public frmMain()
        {
            InitializeComponent();
            graficos = new List<String>();
            numGraficos = 0;
            //graficos.Add("Variación de Temperatura " + (numGraficos + 1).ToString());
            //MessageBox.Show(graficos[0]);
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
            DateTime diasAux = new DateTime(2017, dtpDate.Value.Month, dtpDate.Value.Day);
            Dia diaBase = servDia.obtenerPorFechaSinOcaso(diasAux);
            if (diaBase == null)
            {
                try
                {
                    double horaAmanecer = Convert.ToDouble(txtboxHoraAmanecer.Text);
                    double temperaturaAmanecer = Convert.ToDouble(txtboxTempAmanecer.Text);
                    double temperaturaMaxima = temperaturaAmanecer + 21;
                    dia = new GradoDia(temperaturaMaxima, temperaturaAmanecer, Convert.ToDouble(txtboxTempBase.Text));
                    dia.crearDia(horaAmanecer, temperaturaAmanecer, diasAux);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un problema con los datos");
                }
            }
            else
            {
                MessageBox.Show("Dia encontrado en base de datos");
                txtboxHoraAmanecer.Text = diaBase.HoraAmanecer.ToString();
                txtboxTempAmanecer.Text = diaBase.TemperaturaAmanecer.ToString();
                txtboxHoraAmanecer.Enabled = false;
                txtboxTempAmanecer.Enabled = false;
                dia = new GradoDia(diaBase.TemperaturaMaxima, diaBase.TemperaturaAmanecer, Convert.ToDouble(txtboxTempBase.Text));
                diaBase.TemperaturaOcaso = diaBase.TemperaturaMaxima - (0.39 * (diaBase.TemperaturaMaxima - diaBase.TemperaturaSigDia));
                servDia.editarDia(diaBase);
            }
            this.tmepHora = new TemperaturaHora(diasAux);
            this.tmepHora.guardarTemperaturas(diasAux);
            this.gradosHora = this.dia.gradosHoraCalculo(diasAux);

            this.dgvDatos.Rows.Clear();
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
            try
            {
                generarGrafico();
            }
            catch (Exception)
            {
                MessageBox.Show("Dificultades tecnicas");
            }
        }
        private void generarGrafico()
        {
            if (numGraficos == 0)
            {
                var chart = chart1.ChartAreas[0];
                chart.AxisX.IntervalType = DateTimeIntervalType.Number;

                chart.AxisX.LabelStyle.Format = "";
                chart.AxisY.LabelStyle.Format = "";
                chart.AxisY.LabelStyle.IsEndLabelVisible = true;

                chart.AxisX.Minimum = 0;
                chart.AxisX.Maximum = 23;
                chart.AxisY.Minimum = 0;
                chart.AxisY.Maximum = 30;
                chart.AxisX.Interval = 1;
                chart.AxisY.Interval = 3;

                graficos.Add("Variación de Temperatura " + (numGraficos + 1).ToString());
                chart1.Series.Add(graficos[numGraficos]);
                chart1.Series[graficos[numGraficos]].ChartType = SeriesChartType.Line;
                chart1.Series[graficos[numGraficos]].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                for (numDatos = 0; numDatos < 24; numDatos++)
                {
                    chart1.Series[graficos[numGraficos]].Points.AddXY(numDatos, gradosHora[numDatos]);
                }
            }
            else
            {
                graficos.Add("Variación de Temperatura " + (numGraficos + 1).ToString());
                chart1.Series.Add(graficos[numGraficos]);
                chart1.Series[graficos[numGraficos]].ChartType = SeriesChartType.Line;
                chart1.Series[graficos[numGraficos]].Color = Color.Blue;
                chart1.Series[0].IsVisibleInLegend = false;

                for (int i = 0; i < 24; i++)
                {
                    chart1.Series[graficos[numGraficos]].Points.AddXY(i, gradosHora[numDatos+i]);
                }
                numDatos = numDatos + 24;
            }
            numGraficos++;
        }
    }
}
