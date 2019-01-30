using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CloverEVA.Views
{
    public class ConfigLogica
    {
        public string VADirect { get; set; }
        public string VALineUp { get; set; }
        
        public static bool Guardar(ConfigLogica conf)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string sQuery = "UPDATE t_config SET va_root = '" + conf.VADirect + "', va_lineup = '" + conf.VALineUp + "' WHERE clave = '01'";
                if (DataSource.AccesoDatos.Borrar(sQuery) != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public static bool VerificaGlobals()
        {
            try
            {
                string sQuery;
                sQuery = "SELECT * FROM t_config WHERE ind_globals = '1'";
                DataTable datos = DataSource.AccesoDatos.Consultar(sQuery);
                if (datos.Rows.Count != 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable Consultar()
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("SELECT * FROM t_config");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }
    }
}