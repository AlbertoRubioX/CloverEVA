using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CloverEVA
{
    public partial class WinPopUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Request.QueryString["Codigo"]))
                    return;

                string sVal = Convert.ToString(Request.QueryString["Codigo"]);
                txtName.Text = sVal;
                Views.EstacionLogica est = new Views.EstacionLogica();
                est.Estacion = sVal;

                DataTable dt = Views.EstacionLogica.Consultar(est);
                
                planta.Value = dt.Rows[0]["planta"].ToString();
                linea.Value = dt.Rows[0]["linea"].ToString();

                txtCant1.Text = dt.Rows[0]["area"].ToString();
                txtCant2.Text = dt.Rows[0]["va_timelap"].ToString();

                txtCant2.Focus();
                
            }
                
             
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                Views.EstacionLogica est = new Views.EstacionLogica();
                if (string.IsNullOrEmpty(txtName.Text.ToString()))
                    return;
                if (string.IsNullOrEmpty(txtCant1.Text.ToString()))
                    return;
                if (string.IsNullOrEmpty(txtCant2.Text.ToString()))
                    return;

                est.Estacion = txtName.Text.ToString();

                DataTable dt = Views.EstacionLogica.Consultar(est);
                est.Planta = dt.Rows[0]["planta"].ToString();
                est.Linea = dt.Rows[0]["linea"].ToString();
                est.Proceso = dt.Rows[0]["proceso"].ToString();
                est.Monitor = dt.Rows[0]["ind_monitor"].ToString();
                est.Usuario = dt.Rows[0]["u_id"].ToString();

                est.Area = txtCant1.Text.ToString();
                est.Tiempo = double.Parse(txtCant2.Text.ToString());


                if (Views.EstacionLogica.Guardar(est) > 0)
                    ClientScript.RegisterClientScriptBlock(GetType(), "Close", "window.close()", true);
            }
            catch { throw; }


        }
    }
}