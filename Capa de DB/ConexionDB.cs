using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Floricultivo.Capa_de_DB
{
    public class ConexionDB
    {
        #region Datos miembro
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
        private MySqlConnection conexion;
        #endregion

        #region
        public MySqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        #endregion

        #region Funciones
        public void crearConexion() 
        {
            try
            {
                this.builder.Server = "localhost";
                this.builder.UserID = "floricultivo";
                this.builder.Password = "Floricultivo112358.";
                this.builder.Database = "floricultivo";
                //this.builder.Server = "localhost";
                //this.builder.UserID = "root";
                //this.builder.Password = "18102011d.";
                //this.builder.Database = "Temperaturaproyecto";
                this.conexion = new MySqlConnection(builder.ToString());
                this.conexion.Open();
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void cerrarConexion() 
        {
            try
            {
                this.conexion.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
