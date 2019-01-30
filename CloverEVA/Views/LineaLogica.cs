using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace CloverEVA.Views
{
    public class LineaLogica
    {
        public string Planta { get; set; }
        public string Linea { get; set; }
        public string Nombre { get; set; }
        public string LineaNav { get; set; }
        public string Tipo { get; set; }
        

        public static DataTable Listar(LineaLogica linea)
        {
            DataTable datos = new DataTable();
            try
            {
                string sQuery;
                sQuery = "SELECT planta,linea as Linea,nombre as Nombre,linea_nav as [Linea NAV],tipo as Tipo FROM t_linea where planta = '" + linea.Planta + "'";
                datos = DataSource.AccesoDatos.Consultar(sQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }

        public static DataTable ListarTodas()
        {
            DataTable datos = new DataTable();
            try
            {
                string sQuery; // solo MONO
                sQuery = "SELECT linea FROM t_linea where planta='NIC2' or planta='NIC3' order by linea";
                datos = DataSource.AccesoDatos.Consultar(sQuery);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return datos;
        }
        
    }
}