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
        private double gradosHora;


        private double gradosDiaCalculo()
        {
            this.gradosDia = ((this.temperaturaMaxima+this.temperaturaMinima)/2)-this.temperaturaBase;
            return this.gradosDia;
        }

        private double gradosHoraCalculo()
        {
            tempHora = serviceTemp.obtenerPorDia(DateTime.Now);
            this.gradosHora = tempHora.TemperaturaGrados - this.temperaturaBase;
            return this.gradosHora;
        }

    }
}
