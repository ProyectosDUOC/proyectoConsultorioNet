using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Admin.Paciente
{
    public partial class ListarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = capaNegocio.ClasesListar.PacienteLColeccion.GenerarListado();
                GridView1.DataBind();
            }
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelPaciente.aspx");
        }
    }
}