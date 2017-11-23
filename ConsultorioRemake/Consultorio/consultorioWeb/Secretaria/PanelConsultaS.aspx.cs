using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Secretaria
{
    public partial class PanelConsultaS : System.Web.UI.Page
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
                GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/MenuSecretaria.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/AgregarPacienteConsulta.aspx");
        }

        protected void cambioPagina(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
            GridView1.DataBind();
        }

       
    }
}