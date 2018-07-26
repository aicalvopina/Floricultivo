using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultivo.Capa_de_DB
{
    public class Dia
    {
        #region Datos Miembro
        private Int32 codDia;
        private DateTime fecha;
        private DateTime horaAmanecer;
        private DateTime horaMaxTemperatura;
        private DateTime horaOcaso;
        private DateTime horaSigDia;
        private double temperaturaAmanecer;
        private double temperaturaMaxima;
        private double temperaturaOcaso;
        private double temperaturaSigDia;
        #endregion

        #region Constructor
        public Dia() 
        {
            this.codDia = 0;
            this.fecha = DateTime.Now;
            this.horaAmanecer = DateTime.Now;
            this.horaMaxTemperatura = DateTime.Now;
            this.horaOcaso = DateTime.Now;
            this.horaSigDia = DateTime.Now;
            this.temperaturaAmanecer = 0.0f;
            this.temperaturaMaxima = 0.0f;
            this.temperaturaOcaso = 0.0f;
            this.temperaturaSigDia = 0.0f;
        }
        #endregion

        #region Getters y Setters
        public Int32 CodDia
        {
            get { return codDia; }
            set { codDia = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public DateTime HoraAmanecer
        {
            get { return horaAmanecer; }
            set { horaAmanecer = value; }
        }
        public DateTime HoraMaxTemperatura
        {
            get { return horaMaxTemperatura; }
            set { horaMaxTemperatura = value; }
        }
        public DateTime HoraOcaso
        {
            get { return horaOcaso; }
            set { horaOcaso = value; }
        }
        public DateTime HoraSigDia
        {
            get { return horaSigDia; }
            set { horaSigDia = value; }
        }
        public double TemperaturaAmanecer
        {
            get { return temperaturaAmanecer; }
            set { temperaturaAmanecer = value; }
        }
        public double TemperaturaMaxima
        {
            get { return temperaturaMaxima; }
            set { temperaturaMaxima = value; }
        }
        public double TemperaturaOcaso
        {
            get { return temperaturaOcaso; }
            set { temperaturaOcaso = value; }
        }
        public double TemperaturaSigDia
        {
            get { return temperaturaSigDia; }
            set { temperaturaSigDia = value; }
        }
        #endregion
    }
}
