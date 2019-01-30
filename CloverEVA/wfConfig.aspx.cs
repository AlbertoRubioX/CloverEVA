using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace CloverEVA
{
    public partial class wfConfig : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DataTable dt = Views.ConfigLogica.Consultar();
                txtDirect.Value = dt.Rows[0]["va_root"].ToString();
                if (dt.Rows[0]["va_lineup"].ToString() == "1")
                    chbLineUp.Checked = true;
                else
                    chbLineUp.Checked = false;

            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            Views.ConfigLogica con = new Views.ConfigLogica();
            con.VADirect = txtDirect.Value.ToString();
            if (chbLineUp.Checked)
                con.VALineUp = "1";
            else
                con.VALineUp = "0";
            if(Views.ConfigLogica.Guardar(con))
                ClientScript.RegisterClientScriptBlock(GetType(), "Close", "window.close()", true);
        }
    }
}