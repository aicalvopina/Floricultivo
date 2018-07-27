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
        //Parametros para el calculo
        private double temperaturaMaxima;
        private double temperaturaMinima;
        private double temperaturaBase;
        private Temperatura tempHora;
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
            this.gradosHora = tempHora.TemperaturaGrados - this.temperaturaBase;
            return this.gradosHora;
        }

    }
}
