using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CloverEVA
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Inicio();

            }
        }
        private void Inicio()
        {

            DataTable dt = Views.LineaLogica.ListarTodas();
            ddLine.DataSource = dt;
            ddLine.DataValueField = "linea";
            ddLine.DataTextField = "linea";
            ddLine.DataBind();
            ddLine.SelectedIndex = -1;
        }

        protected void ddLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (ddLine.SelectedIndex == -1)
            //    return;

            //Views.EstacionLogica est = new Views.EstacionLogica();
            //est.Linea = ddLine.SelectedValue.ToString();
            //DataTable dt = Views.EstacionLogica.ListarEstacionLinea(est);
            //gvData.DataSource = dt;
            //gvData.DataBind();
        }

        protected void gvData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int iDx = gvData.EditIndex;
            string sEst = gvData.Rows[iDx].Cells[1].ToString();
        }

        protected void btLoad_Click(object sender, EventArgs e)
        {
            if (ddLine.SelectedIndex == -1)
                return;

            Views.EstacionLogica est = new Views.EstacionLogica();
            est.Linea = ddLine.SelectedValue.ToString();
            DataTable dt = Views.EstacionLogica.ListarEstacionLinea(est);
            gvData.DataSource = dt;
            gvData.DataBind();
        }
    }
}