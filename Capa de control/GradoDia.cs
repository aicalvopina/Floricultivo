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
        private double temperaturaMaxima;
        private double temperaturaMinima;
        private double temperaturaBase;
        private List<Temperatura> tempHora;

        //Resultados
        private double gradosDia;
        private List<double> gradosHora;

        public GradoDia()
        {

        }
        private double gradosDiaCalculo()
        {
            this.gradosDia = ((this.temperaturaMaxima+this.temperaturaMinima)/2)-this.temperaturaBase;
            return this.gradosDia;
        }

        private List<double> gradosHoraCalculo(DateTime fecha)
        {
            tempHora = serviceTemp.obtenerPorFecha(fecha);
            for (int i = 0; i < tempHora.Count; i++ )
            {
                this.gradosHora.Add(tempHora[i].TemperaturaGrados - this.temperaturaBase);
            }
            return this.gradosHora;
        }

    }
}
