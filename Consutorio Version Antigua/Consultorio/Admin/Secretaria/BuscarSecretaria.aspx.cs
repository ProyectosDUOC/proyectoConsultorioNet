using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio.Admin.Secreataria
{
    public partial class BuscarSecretaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelSecretaria.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/ModificarSecretaria.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/EliminarSecretaria.aspx");
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelSecretaria.aspx");
        }
    }
}