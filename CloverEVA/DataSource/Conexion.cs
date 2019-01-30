using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace CloverEVA.DataSource
{
    public class Conexion
    {
        public static string cadenaConexion = ConfigurationManager.ConnectionStrings["CloverPRO_ConnectionDebug"].ToString();
        public static string CadenaConexion()
        {
            return cadenaConexion;
        }
    }
}