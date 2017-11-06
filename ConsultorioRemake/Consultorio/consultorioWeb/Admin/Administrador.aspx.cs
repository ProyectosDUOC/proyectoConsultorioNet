using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Admin
{
    public partial class Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPaci_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelPaciente.aspx");
        }

        protected void btnEnfermera_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }

        protected void btnMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelMedico.aspx");
        }

        protected void btnSecretaria_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelSecretaria.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }
      
    }
}