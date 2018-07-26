using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultivo.Capa_de_control
{
    class GradoDia
    {
        private double temperaturaMaxima;
        private double temperaturaMinima;
        private double temperaturaBase;
        private double gradosDia;
        private double gradosHora;

        private double gradosDiaCalculo()
        {
            this.gradosDia = ((this.temperaturaMaxima+this.temperaturaMinima)/2)-this.temperaturaBase;
            return this.gradosDia;
        }

    }
}
