using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CloverEVA.DataSource
{
    public class AccesoDatos
    {
        public static int Actualizar(string as_procedimiento, string[] nomparametros, params Object[] valparametros)
        {
            if (nomparametros.Length == valparametros.Length)
            {
                SqlCommand _comando = MetodosDatos.CrearComandoSP(as_procedimiento);
                int i = 0;
                foreach (string nomparam in nomparametros)
                    _comando.Parameters.AddWithValue(nomparam, ToDBNull(valparametros[i++]));

                return MetodosDatos.EjecutaComando(_comando);
            }
            return 0;
        }
        private static object ToDBNull(object value)
        {
            if (null != value)
            {
                Type t = value.GetType();
                if (t.Equals(typeof(DateTime)))
                {
                    if (value.Equals(DateTime.MinValue))
                        return DBNull.Value;
                    else
                        return value;
                }
                else
                    return value;
            }
            return DBNull.Value;
        }
        public static DataTable ConsultaSP(string as_procedimiento, string[] nomparametros, params object[] valparametros)
        {
            DataTable dt = new DataTable();
            if (nomparametros.Length == valparametros.Length)
            {
                SqlCommand _comando = MetodosDatos.CrearComandoSP(as_procedimiento);
                int i = 0;
                foreach (string nomparam in nomparametros)
                    _comando.Parameters.AddWithValue(nomparam, ToDBNull(valparametros[i++]));

                dt = MetodosDatos.EjecutaComandoSelect(_comando);
            }
            return dt;
        }
        public static DataTable Consultar(string as_query)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = as_query;
            return MetodosDatos.EjecutaComandoSelect(_comando);
        }
        public static int Borrar(string as_query)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = as_query;
            return MetodosDatos.EjecutaComando(_comando);
        }
        
    }
}