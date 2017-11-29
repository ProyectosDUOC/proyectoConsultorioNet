using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Medico
{
    public partial class HistorialMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Medico/PanelConsultaM.aspx");
        }
    }
}