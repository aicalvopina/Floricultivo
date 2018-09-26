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
using System.Windows.Forms.DataVisualization.Charting;

namespace Floricultivo
{
    public partial class frmMain : Form
    {
        frmInformacion form2 = new frmInformacion();
        GradoDia dia;
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
            double horaAmanecer = Convert.ToDouble(txtboxHoraAmanecer.Text);
            double temperaturaAmanecer = Convert.ToDouble(txtboxTempAmanecer.Text);
            double temperaturaMaxima = temperaturaAmanecer + 21;
            DateTime diasAux = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day);
            dia = new GradoDia(temperaturaMaxima, temperaturaAmanecer, Convert.ToDouble(txtboxTempBase.Text));
            dia.crearDia(horaAmanecer, temperaturaAmanecer, diasAux);
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
            generarGrafico();
        }
        private void generarGrafico()
        {
            //float x1 = 17;
            //float x2 = 25;
            //float x3 = 35;
            //float x4 = 38;
            //float x5 = 12;
            //float x6 = 19;
            //float x7 = 41;
            //float x8 = 7;
            //float x9 = 36;
            //float x10 = 28;
            //float x11 = 44;
            //float x12 = 22;
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
                chart1.Series[graficos[numGraficos]].Color = Color.Red;
                chart1.Series[0].IsVisibleInLegend = false;

                for (int i = numDatos; i < 24; i++)
                {
                    chart1.Series[graficos[numGraficos]].Points.AddXY(i, gradosHora[i]);
                }
            }
            numDatos = numDatos + 24;
            numGraficos++;
            //chart1.Series["Hola"].Points.AddXY(1, x1);
            //chart1.Series["Hola"].Points.AddXY(2, x2);
            //chart1.Series["Hola"].Points.AddXY(3, x3);
            //chart1.Series["Hola"].Points.AddXY(4, x4);
            //chart1.Series["Hola"].Points.AddXY(5, x5);
            //chart1.Series["Hola"].Points.AddXY(6, x6);
            //chart1.Series["Hola"].Points.AddXY(7, x7);
            //chart1.Series["Hola"].Points.AddXY(8, x8);
            //chart1.Series["Hola"].Points.AddXY(9, x9);
            //chart1.Series["Hola"].Points.AddXY(10, x10);
            //chart1.Series["Hola"].Points.AddXY(11, x11);
            //chart1.Series["Hola"].Points.AddXY(12, x12);
        }
    }
}
