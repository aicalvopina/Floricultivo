using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultivo.Capa_de_DB
{
    public class Temperatura
    {
        #region Datos miembro
        private Int32 codTemperatura;
        private Int32 codDia;
        private DateTime hora;
        private double temperaturaGrados;
        #endregion

        #region Constructor
        public Temperatura() 
        {
            this.codTemperatura = 0;
            this.codDia = 0;
            this.hora = DateTime.Now;
            this.temperaturaGrados = 0.0f;
        }
        #endregion

        #region Getter y Setters
        public int CodTemperatura
        {
            get { return codTemperatura; }
            set { codTemperatura = value; }
        }
        public int CodDia
        {
            get { return codDia; }
            set { codDia = value; }
        }

        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        public double TemperaturaGrados
        {
            get { return temperaturaGrados; }
            set { temperaturaGrados = value; }
        }
        #endregion
    }
}
