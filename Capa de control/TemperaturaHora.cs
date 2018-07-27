using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floricultivo.Capa_de_DB;

namespace Floricultivo.Capa_de_control
{
    class TemperaturaHora
    {
        private Dia diaEstimar;
        private DiaServicio service =  new DiaServicio();
        private TemperaturaServicio serviceTemp = new TemperaturaServicio();
        //Parametros para la estimacion
        private double c = 0.39;
        private double pi = Math.PI;
        private double difTxTn;
        private double difTxTo;
        private double difTpTo;
        public TemperaturaHora(DateTime dia)
        {
            diaEstimar = service.obtenerPorFecha(dia);
            diaEstimar.TemperaturaAmanecer = diaEstimar.TemperaturaMaxima - (c * (diaEstimar.TemperaturaMaxima - diaEstimar.TemperaturaSigDia));
            difTxTo = diaEstimar.TemperaturaMaxima - diaEstimar.TemperaturaOcaso;
            difTxTn = diaEstimar.TemperaturaMaxima - diaEstimar.TemperaturaAmanecer;
            difTpTo = (diaEstimar.TemperaturaSigDia - diaEstimar.TemperaturaAmanecer) / Math.Sqrt(Convert.ToDouble(diaEstimar.HoraSigDia) - Convert.ToDouble(diaEstimar.HoraAmanecer));   
        }
        private double primerSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaAmanecer +
                      (difTxTn * ((Convert.ToDouble(hora) - Convert.ToDouble(diaEstimar.HoraAmanecer)) / (Convert.ToDouble(diaEstimar.HoraMaxTemperatura) - Convert.ToDouble(diaEstimar.HoraAmanecer)) * (pi / 2)));
        }
        private double segundoSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaOcaso + (difTxTo * Math.Sin((pi / 2) + ((Convert.ToDouble(hora) - Convert.ToDouble(diaEstimar.HoraMaxTemperatura)) / 4) * (pi / 2)));
        }
        private double tercerSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaOcaso + (difTpTo * Math.Sqrt(Convert.ToDouble(hora) - Convert.ToDouble(diaEstimar.HoraOcaso)));
        }
        public double estimarTemperaturas(DateTime hora){
            if (diaEstimar.HoraAmanecer < hora && hora <= diaEstimar.HoraMaxTemperatura){
                return primerSegmento(hora);
            }else if(diaEstimar.HoraMaxTemperatura < hora && diaEstimar.HoraOcaso > hora){
                return segundoSegmento(hora);
            } else if(diaEstimar.HoraOcaso < hora && hora <= diaEstimar.HoraSigDia){
                return tercerSegmento(hora);
            }
            return 0;
        }

        public void guardarTemperaturas(DateTime hora)
        {
            DateTime horaAux = DateTime.Now;
            Temperatura objTemp =  new Temperatura();
            objTemp.CodDia = diaEstimar.CodDia;
            for (int i = 0; i < 24; i++)
            {
                objTemp.Hora = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, i, 0, 0);
                objTemp.TemperaturaGrados = estimarTemperaturas(objTemp.Hora);
            }
            serviceTemp.crearTemperatura(objTemp);
        }
       

    }
}
