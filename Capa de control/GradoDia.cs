using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floricultivo.Capa_de_DB;

namespace Floricultivo.Capa_de_control
{
    class GradoDia
    {

        private TemperaturaServicio serviceTemp = new TemperaturaServicio();
        //Parametros para el calculo
        private double temperaturaMaxima =  0F;
        private double temperaturaMinima = 0F;
        private double temperaturaBase = 0F;
        private List<Temperatura> tempHora;

        private DiaServicio diaServ = new DiaServicio();
        //Resultados
        private double gradosDia;
        private List<double> gradosHora;

        public GradoDia(double tempMx, double tempMin, double tempBase)
        {
            gradosHora = new List<Double>();
            this.temperaturaMaxima = tempMx;
            this.temperaturaMinima = tempMin;
            this.temperaturaBase = tempBase;

        }
        public double gradosDiaCalculo()
        {
            this.gradosDia = ((this.temperaturaMaxima+this.temperaturaMinima)/2)-this.temperaturaBase;
            return this.gradosDia;
        }

        public List<double> gradosHoraCalculo(DateTime fecha)
        {
            tempHora = new List<Temperatura>();
            tempHora = serviceTemp.obtenerPorFecha(fecha);
            for (int i = 0; i < tempHora.Count; i++ )
            {
                this.gradosHora.Add(tempHora[i].TemperaturaGrados - this.temperaturaBase);
            }
            return this.gradosHora;
        }

        public void crearDia(double horaAmanecer ,double temperaturaAmanecer,DateTime diaEstimar)
        {
            double horaOcaso = horaAmanecer + 12;
            double horaTemMax = horaOcaso - 4;
            double temperaturaMaxima = temperaturaAmanecer + 21;
            double temperaturaOcaso = temperaturaMaxima - 4;
            Dia dia = new Dia();
            DateTime horaAux = DateTime.Now;
            dia.Fecha = diaEstimar;
            dia.HoraAmanecer = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, Convert.ToInt32(horaAmanecer), 0, 0);
            dia.HoraMaxTemperatura = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, Convert.ToInt32(horaTemMax), 0, 0);
            dia.HoraOcaso = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, Convert.ToInt32(horaOcaso), 0, 0);
            dia.HoraSigDia = dia.HoraAmanecer;
            dia.TemperaturaAmanecer = temperaturaAmanecer;
            dia.TemperaturaMaxima = temperaturaMaxima;
            dia.TemperaturaOcaso = temperaturaOcaso;
            dia.TemperaturaSigDia = temperaturaAmanecer;
            diaServ.crearDia(dia);


        }
    }
}
