using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Admin.Enfermera
{
    public partial class RegistroEnfermera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }
    }
}