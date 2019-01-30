using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CloverEVA.Views
{
    public class EstacionLogica
    {
        public string Estacion { get; set; }
        public string Planta { get; set; }
        public string Linea { get; set; }
        public string Proceso { get; set; }
        public string Area { get; set; }
        public string Monitor { get; set; }
        public double Tiempo { get; set; }
        public string Usuario { get; set; }

        public static int Guardar(EstacionLogica est)
        {
            string[] parametros = { "@Estacion", "@Planta", "@Linea", "@Proceso", "@Area", "@Monitor", "@Tiempo", "@Usuario" };
            return DataSource.AccesoDatos.Actualizar("sp_mant_estacion_va", parametros, est.Estacion, est.Planta, est.Linea, est.Proceso, est.Area, est.Monitor, est.Tiempo, est.Usuario);
        }

        public static DataTable Consultar(EstacionLogica est)
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("SELECT * FROM t_estacion WHERE estacion = '" + est.Estacion + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static bool Verificar(EstacionLogica est)
        {
            try
            {
                string sQuery;
                sQuery = "SELECT * FROM t_estacion WHERE estacion = '" + est.Estacion + "' and (planta='EMP' or planta='EMPN')";
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

        public static bool VerificarVAids(EstacionLogica est)
        {
            try
            {
                string sQuery;
                sQuery = "SELECT * FROM t_estacion WHERE estacion = '" + est.Estacion + "' and proceso = 'ING010'";
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

        public static bool VerificarMon(EstacionLogica est)
        {
            try
            {
                string sQuery;
                sQuery = "SELECT * FROM t_estacion WHERE estacion = '" + est.Estacion + "' and ind_monitor='1'";
                DataTable datos = DataSource.AccesoDatos.Consultar(sQuery);
                if (datos.Rows.Count != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                string sEx = ex.ToString();
                return false;
            }
        }

        public static DataTable Listar()
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("SELECT * FROM t_estacion");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static DataTable ListarEstacionLinea(EstacionLogica est)
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("SELECT estacion,RIGHT('000'+ISNULL(area,''),2) as area,va_timelap,ind_monitor,u_id,'0' as ind FROM t_estacion where linea = '" + est.Linea + "' AND proceso='ING010' order by 2 ");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static DataTable ListarProceso()
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("select m4.proceso,m2.descrip from t_mod04 m4 inner join t_mod02 m2 on m4.modulo = m2.modulo and m4.proceso = m2.proceso");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static bool Eliminar(EstacionLogica est)
        {
            try
            {
                string sQuery = "DELETE FROM t_estacion WHERE estacion = '" + est.Estacion + "'";
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
    }
}