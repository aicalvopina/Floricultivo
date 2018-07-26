using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Floricultivo.Capa_de_DB
{
    public class TemperaturaServicio
    {
        #region Datos Miembro
        private ConexionDB conn = new ConexionDB();
        private MySqlDataReader consultar;
        private MySqlCommand query = new MySqlCommand();
        #endregion

        #region Funciones
        public List<Temperatura> obtenerTodos() 
        {
            try
            {
                List<Temperatura> temperaturas = new List<Temperatura>();
                conn.crearConexion();
                query.CommandText = "select * from floricultivo.temperatura;";
                query.Connection = conn.Conexion;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    Temperatura temperatura = new Temperatura();
                    temperatura.CodTemperatura = consultar.GetInt32("COD_TEMPERATURA");
                    temperatura.CodDia = consultar.GetInt32("COD_DIA");
                    temperatura.Hora = consultar.GetDateTime("HORA");
                    temperatura.TemperaturaGrados = consultar.GetDouble("TEMPERATURA");
                    temperaturas.Add(temperatura);
                }
                conn.cerrarConexion();
                return temperaturas;
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Temperatura obtenerPorId(Int32 idTemperatura) 
        {
            try
            {
                Temperatura temperatura = new Temperatura();
                conn.crearConexion();
                query.CommandText = "select * from floricultivo.temperatura where cod_temperatura = " + idTemperatura + ";";
                query.Connection = conn.Conexion;
                consultar = query.ExecuteReader();
                while (consultar.Read())
                {
                    temperatura.CodTemperatura = consultar.GetInt32("COD_TEMPERATURA");
                    temperatura.CodDia = consultar.GetInt32("COD_DIA");
                    temperatura.Hora = consultar.GetDateTime("HORA");
                    temperatura.TemperaturaGrados = consultar.GetDouble("TEMPERATURA");
                }
                conn.cerrarConexion();
                return temperatura;
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void crearTemperatura(Temperatura temperatura) 
        {
            try
            {
                conn.crearConexion();
                query.CommandText = "insert into floricultivo.temperatura (cod_dia, hora, temperatura) values (" + temperatura.CodDia + ", "
                    + "'" + temperatura.Hora.ToString("yyyy-MM-dd H:mm:ss") + "', " + temperatura.TemperaturaGrados + ");";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void eliminarTemperatura(Int32 idTemperatura) 
        {
            try
            {
                conn.crearConexion();
                query.CommandText = "delete from floricultivo.temperatura where cod_temperatura = " + idTemperatura + ";";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            }catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void editarTemperatura(Temperatura temperatura) 
        {
            try 
            {
                conn.crearConexion();
                query.CommandText = "update floricultivo.temperatura set cod_dia = " + temperatura.CodDia + ", hora = '"
                    + temperatura.Hora.ToString("yyyy-MM-dd H:mm:ss") + "', temperatura = " + temperatura.TemperaturaGrados
                    + " where cod_temperatura = " + temperatura.CodTemperatura + ";";
                query.Connection = conn.Conexion;
                query.ExecuteReader();
                conn.cerrarConexion();
            } 
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
