using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;

namespace Sol_Punto_Venta.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        private Conexion() {
            this.Base = "BD_PUNTO_VENTA";
            this.Servidor = "LAPTOP-DJGS1F2F";
            this.Usuario = "user_sistema";
            this.Clave = "Tatiana492";
        }
        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor +
                                          "; Database=" + this.Base +
                                          "; User Id=" + this.Usuario +
                                          "; Password=" + this.Clave;
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion getInstancia() { 
        if (Con == null) {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
