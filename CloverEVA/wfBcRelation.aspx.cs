using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CloverEVA
{
    public partial class wfBcRelation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Inicio();
            }
        }
        private void Inicio()
        {
            DataTable dt = Views.ModerelaLogica.Consultar();
            ddLine.DataSource = dt;
            ddLine.DataValueField = "modrel";
            ddLine.DataTextField = "modrel";
            ddLine.DataBind();
            ddLine.SelectedIndex = -1;
        }
        private void FillGrid()
        {
            Views.ModerelaLogica mod = new Views.ModerelaLogica();
            mod.Moderela = ddLine.SelectedValue.ToString();
            DataTable dt = Views.ModerelaLogica.Listar(mod);
            gwData.DataSource = dt;
            gwData.DataBind();
        }

        protected void btLoad_Click(object sender, EventArgs e)
        {
            if (ddLine.SelectedIndex == -1)
                return;

            FillGrid();
            
        }

        protected void gwData_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gwData.EditIndex = e.NewEditIndex;
            FillGrid();
        }

        protected void gwData_DataBound(object sender, EventArgs e)
        {
            
        }

        protected void gwData_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            for (int colcnt = 1; colcnt < e.Row.Cells.Count - 1; colcnt++)
            {
                e.Row.Cells[colcnt].Enabled = false;
            }
        }

        protected void gwData_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gwData.EditIndex = -1;
            FillGrid();
        }

        protected void gwData_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void gwData_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string sModelo = gwData.DataKeys[e.RowIndex].Values[0].ToString();

            GridViewRow row = (GridViewRow)gwData.Rows[e.RowIndex];
            
            string sVAfolder = "";
            if (e.NewValues[4] != null)
                sVAfolder = e.NewValues[4].ToString();
            
            Views.ModerelaLogica mod = new Views.ModerelaLogica();
            mod.Modelo = sModelo;
            mod.Moderela = ddLine.SelectedValue.ToString();
            mod.VAFolder = sVAfolder;

            Views.ModerelaLogica.UpdateFolder(mod);
            gwData.EditIndex = -1;
            FillGrid();
            
        }
    }
}