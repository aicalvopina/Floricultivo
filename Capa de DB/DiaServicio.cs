using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Floricultivo.Capa_de_DB
{
    public class DiaServicio
    {
        #region Datos Miembro
        private ConexionDB conn = new ConexionDB();
        private MySqlDataReader consultar;
        private MySqlCommand query = new MySqlCommand();
        #endregion

        #region Funciones
        public List<Dia> obtenerTodos() 
        {
            try
            {
                List<Dia> dias = new List<Dia>();
                conn.crearConexion();
                query.CommandText = "select * from floricultivo.dia;";
                query.Connection = conn.Conexion;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    Dia dia = new Dia();
                    dia.CodDia = consultar.GetInt32("cod_dia");
                    dia.Fecha = consultar.GetDateTime("fecha");
                    dia.HoraAmanecer = consultar.GetDateTime("hora_amanecer");
                    dia.HoraMaxTemperatura = consultar.GetDateTime("hora_max_temperatura");
                    dia.HoraOcaso = consultar.GetDateTime("hora_ocaso");
                    dia.HoraSigDia = consultar.GetDateTime("hora_sig_dia");
                    dia.TemperaturaAmanecer = consultar.GetDouble("temperatura_amanecer");
                    dia.TemperaturaMaxima = consultar.GetDouble("temperatura_maxima");
                    dia.TemperaturaOcaso = consultar.GetDouble("temperatura_ocaso");
                    dia.TemperaturaSigDia = consultar.GetDouble("temperatura_sig_dia");
                    dias.Add(dia);
                }
                conn.cerrarConexion();
                return dias;
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Dia obtenerPorId(Int32 idDia)
        {
            try
            {
                Dia dia = new Dia();
                conn.crearConexion();
                query.CommandText = "select *  from floricultivo.dia where cod_dia = " + idDia + ";";
                query.Connection = conn.Conexion;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    dia.CodDia = consultar.GetInt32("cod_dia");
                    dia.Fecha = consultar.GetDateTime("fecha");
                    dia.HoraAmanecer = consultar.GetDateTime("hora_amanecer");
                    dia.HoraMaxTemperatura = consultar.GetDateTime("hora_max_temperatura");
                    dia.HoraOcaso = consultar.GetDateTime("hora_ocaso");
                    dia.HoraSigDia = consultar.GetDateTime("hora_sig_dia");
                    dia.TemperaturaAmanecer = consultar.GetDouble("temperatura_amanecer");
                    dia.TemperaturaMaxima = consultar.GetDouble("temperatura_maxima");
                    dia.TemperaturaOcaso = consultar.GetDouble("temperatura_ocaso");
                    dia.TemperaturaSigDia = consultar.GetDouble("temperatura_sig_dia");
                }
                conn.cerrarConexion();
                return dia;
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Dia obtenerPorFecha(DateTime fecha) 
        {
            try
            {
                Dia dia = new Dia();
                conn.crearConexion();
                query.CommandText = "select * from floricultivo.dia where fecha = '" + fecha.ToString("yyyy-MM-dd H:mm:ss") + "';";
                query.Connection = conn.Conexion;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    dia.CodDia = consultar.GetInt32("cod_dia");
                    dia.Fecha = consultar.GetDateTime("fecha");
                    dia.HoraAmanecer = consultar.GetDateTime("hora_amanecer");
                    dia.HoraMaxTemperatura = consultar.GetDateTime("hora_max_temperatura");
                    dia.HoraOcaso = consultar.GetDateTime("hora_ocaso");
                    dia.HoraSigDia = consultar.GetDateTime("hora_sig_dia");
                    dia.TemperaturaAmanecer = consultar.GetDouble("temperatura_amanecer");
                    dia.TemperaturaMaxima = consultar.GetDouble("temperatura_maxima");
                    dia.TemperaturaOcaso = consultar.GetDouble("temperatura_ocaso");
                    dia.TemperaturaSigDia = consultar.GetDouble("temperatura_sig_dia");
                }
                conn.cerrarConexion();
                return dia;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void crearDia(Dia dia) 
        {
            try
            {
                conn.crearConexion();
                query.CommandText = "insert into floricultivo.dia (fecha, hora_amanecer, hora_max_temperatura, hora_ocaso, hora_sig_dia, temperatura_amanecer," +
                " temperatura_maxima, temperatura_ocaso, temperatura_sig_dia) values ('" + dia.Fecha.ToString("yyyy-MM-dd H:mm:ss") + "', '" + dia.HoraAmanecer.ToString("yyyy-MM-dd H:mm:ss")
                + "', '" + dia.HoraMaxTemperatura.ToString("yyyy-MM-dd H:mm:ss") + "', '" + dia.HoraOcaso.ToString("yyyy-MM-dd H:mm:ss") + "', '" + dia.HoraSigDia.ToString("yyyy-MM-dd H:mm:ss")
                + "', " + dia.TemperaturaAmanecer + ", " + dia.TemperaturaMaxima + ", " + dia.TemperaturaOcaso + ", " + dia.TemperaturaSigDia + ");";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void eliminarDia(Int32 idDia)
        {
            try
            {
                conn.crearConexion();
                query.CommandText = "delete from floricultivo.dia where cod_dia = " + idDia + ";";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void editarDia(Dia dia)
        {
            try
            {
                conn.crearConexion();
                query.CommandText = "update floricultivo.dia set fecha = '" + dia.Fecha.ToString("yyyy-MM-dd H:mm:ss") + "', hora_amanecer = '" + dia.HoraAmanecer.ToString("yyyy-MM-dd H:mm:ss")
                    + "', hora_max_temperatura = '" + dia.HoraMaxTemperatura.ToString("yyyy-MM-dd H:mm:ss") + "', hora_ocaso = '" + dia.HoraOcaso.ToString("yyyy-MM-dd H:mm:ss")
                    + "', hora_sig_dia = '" + dia.HoraSigDia.ToString("yyyy-MM-dd H:mm:ss") + "', temperatura_amanecer = " + dia.TemperaturaAmanecer + ", temperatura_maxima = "
                    + dia.TemperaturaMaxima + ", temperatura_ocaso = " + dia.TemperaturaOcaso + ", temperatura_sig_dia = " + dia.TemperaturaSigDia + " where cod_dia = "
                    + dia.CodDia + ";";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
