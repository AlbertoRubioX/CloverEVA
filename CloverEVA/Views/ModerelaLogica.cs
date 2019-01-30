using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CloverEVA.Views
{
    public class ModerelaLogica
    {
        public string Modelo { get; set; }
        public int Consec { get; set; }
        public string Moderela { get; set; }
        public string VAFolder { get; set; }
        public string Usuario { get; set; }

        //public static int Guardar(ModerelaLogica mode)
        //{
        //    //string[] parametros = { "@Modelo", "@Consec", "@Modrel", "@Nota", "@Usuario" };
        //    //return DataSource.AccesoDatos.Actualizar("sp_mant_moderela", parametros, mode.Modelo, mode.Consec, mode.Moderela, mode.Nota, mode.Usuario);
        //}
        public static bool UpdateFolder(ModerelaLogica mode)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string sQuery = "UPDATE t_modelo SET va_folder='" + mode.VAFolder  + "' WHERE modelo = '" + mode.Modelo + "' ";
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
        public static DataTable Consultar()
        {
            DataTable datos = new DataTable();
            try
            {
                string sSql = "SELECT distinct modrel FROM t_moderela md INNER JOIN t_modelo mo on md.modelo = mo.modelo "+
                "WHERE mo.planta = 'MON' and mo.ind_formatostd = '1' and mo.estatus = 'A' and md.modrel is not null and md.modrel > '' order by md.modrel";
                datos = DataSource.AccesoDatos.Consultar(sSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static DataTable ConsultaRelacionado(ModerelaLogica mode)
        {
            DataTable datos = new DataTable();
            try
            {
                datos = DataSource.AccesoDatos.Consultar("SELECT mo.tipo AS CORE,mr.modelo AS LAYOUT,mr.nota as NOTA,mo.ind_formatostd FROM t_moderela mr INNER JOIN t_modelo mo on mr.modelo = mo.modelo WHERE mr.modrel = '" + mode.Moderela + "' AND mo.estatus='A'");
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static DataTable Listar(ModerelaLogica mode)
        {
            DataTable datos = new DataTable();
            try
            {
                string sSql = "SELECT mo.modelo,mo.descrip,mo.tipo,mo.crc_conv,mo.va_folder "+
                "FROM t_moderela md inner join t_modelo mo on md.modelo = mo.modelo "+
                "WHERE mo.ind_formatostd = '1' and mo.estatus = 'A' and md.modrel = '"+mode.Moderela+"' "+
                "ORDER BY md.modelo";
                datos = DataSource.AccesoDatos.Consultar(sSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static bool Verificar(ModerelaLogica mode)
        {
            try
            {
                string sQuery;
                sQuery = "SELECT * FROM t_moderela WHERE modelo = '" + mode.Modelo + "' and consec = " + mode.Consec + "";
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
    }
}