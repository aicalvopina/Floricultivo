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
        private Dia diaEstimar = new Dia();
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
            difTpTo = (diaEstimar.TemperaturaSigDia - diaEstimar.TemperaturaAmanecer) / Math.Sqrt(Convert.ToDouble(diaEstimar.HoraSigDia.Hour) - Convert.ToDouble(diaEstimar.HoraAmanecer.Hour));   
        }
        private double primerSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaAmanecer +
                      (difTxTn * ((Convert.ToDouble(hora.Hour) - Convert.ToDouble(diaEstimar.HoraAmanecer.Hour)) / (Convert.ToDouble(diaEstimar.HoraMaxTemperatura.Hour) - Convert.ToDouble(diaEstimar.HoraAmanecer.Hour)) * (pi / 2)));
        }
        private double segundoSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaOcaso + (difTxTo * Math.Sin((pi / 2) + ((Convert.ToDouble(hora.Hour) - Convert.ToDouble(diaEstimar.HoraMaxTemperatura.Hour)) / 4) * (pi / 2)));
        }
        private double tercerSegmento(DateTime hora)
        {
            return diaEstimar.TemperaturaOcaso + (difTpTo * Math.Sqrt(Convert.ToDouble(hora.Hour) - Convert.ToDouble(diaEstimar.HoraOcaso.Hour)));
        }

        private double estimarTemperaturas(DateTime hora){
            if (diaEstimar.HoraAmanecer.Hour < hora.Hour && hora.Hour <= diaEstimar.HoraMaxTemperatura.Hour){
                return primerSegmento(hora);
            }
            else if (diaEstimar.HoraMaxTemperatura.Hour < hora.Hour && diaEstimar.HoraOcaso.Hour >= hora.Hour)
            {
                return segundoSegmento(hora);
            }
            else 
            {
                return tercerSegmento(hora);
            }
        }

        public void guardarTemperaturas(DateTime dia)
        {
            DateTime horaAux = dia;
            Temperatura objTemp =  new Temperatura();
            objTemp.CodDia = diaEstimar.CodDia;
            objTemp.Hora = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, 0, 0, 0);
            objTemp.TemperaturaGrados = estimarTemperaturas(new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, 23, 0, 0));
            serviceTemp.crearTemperatura(objTemp);
            for (int i = 1 ; i < 24; i++)
            {
                objTemp.Hora = new DateTime(horaAux.Year, horaAux.Month, horaAux.Day, i, 0, 0);
                objTemp.TemperaturaGrados = estimarTemperaturas(objTemp.Hora);
                serviceTemp.crearTemperatura(objTemp);
            } 
        }
       

    }
}
