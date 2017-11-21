using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Admin
{
    public partial class Administrador : System.Web.UI.Page
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
            lbl_Nombre.Text = controlAcceso.Id.ToString();
            if (!IsPostBack)
            {
                if (controlAcceso.Id==0)
                {                    
                    Response.Redirect("/Login.aspx");
                }
            }
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