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

            capaNegocio.Usuario usuario = new Usuario();
            usuario.Id = controlAcceso.IdUsuario;
            usuario.Read();
            lbl_Nombre.Text = "";
            lbl_rut.Text  = "";

            lbl_Nombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            lbl_rut.Text = usuario.Rut + "-" + usuario.Dv;
            DateTime hoy = DateTime.Now;
            lblFecha.Text = "Fecha: " + hoy;

            if (!IsPostBack)
            {
                if (controlAcceso.Id==0)
                {                    
                    Response.Redirect("../Login.aspx");
                }
            }
        }

        protected void btnPaci_Click(object sender, EventArgs e)
        {
            Response.Redirect("PanelPaciente.aspx");
        }

        protected void btnEnfermera_Click(object sender, EventArgs e)
        {
            Response.Redirect("PanelEnfermera.aspx");
        }

        protected void btnMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("PanelMedico.aspx");
        }

        protected void btnSecretaria_Click(object sender, EventArgs e)
        {
            Response.Redirect("PanelSecretaria.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            controlAcceso = new ControlAcceso();
            Response.Redirect("../Login.aspx");

        }
      
    }
}