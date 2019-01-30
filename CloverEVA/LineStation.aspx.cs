using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CloverEVA
{
    public partial class LineStation : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Inicio();
                
            }

        }
        private void Columnas()
        {
            
        }
        private void Inicio()
        {

            DataTable dt = Views.LineaLogica.ListarTodas();
            
        }
    }
}