using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio.Admin.Enfermera
{
    public partial class ListarEnfermera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }
    }
}