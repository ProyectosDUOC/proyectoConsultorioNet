using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Admin.Medico
{
    public partial class RegistroMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddGenero.DataSource = capaNegocio.GeneroColeccion.ReadAll();
                ddGenero.DataBind();
            }
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin/PanelMedico.aspx");
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin/PanelMedico.aspx");
        }
    }
}