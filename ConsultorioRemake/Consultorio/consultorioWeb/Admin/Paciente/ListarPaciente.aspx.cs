using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Admin.Paciente
{
    public partial class ListarPaciente : System.Web.UI.Page
    {
        private ControlAcceso controlAcceso
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Session["MiUsuario"] = new ControlAcceso();
                }
                return (ControlAcceso)Session["MiUsuario"];
            }
            set { Session["MiUsuario"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = capaNegocio.ClasesListar.PacienteLColeccion.GenerarListado();
                GridView1.DataBind();
                if (controlAcceso.Id == 0)
                {
                    Response.Redirect("/Login.aspx");
                }
            }
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelPaciente.aspx");
        }
    }
}