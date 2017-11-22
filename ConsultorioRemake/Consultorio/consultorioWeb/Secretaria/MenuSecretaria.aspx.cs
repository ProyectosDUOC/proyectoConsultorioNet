using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Secretaria
{
    public partial class MenuSecretaria : System.Web.UI.Page
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
            
            capaNegocio.Usuario usuario = new Usuario();
            usuario.Id = controlAcceso.IdUsuario;
            usuario.Read();
            lblNombre.Text = "";
            lblRut.Text = "";

            lblNombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            lblRut.Text = usuario.Rut + "-" + usuario.Dv;
            DateTime hoy = DateTime.Now;
            lblFecha.Text = "Fecha: " + hoy;

            if (!IsPostBack)
            {
                if (controlAcceso.Id == 0)
                {
                    Response.Redirect("/Login.aspx");
                }
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            controlAcceso = new ControlAcceso();
            Response.Redirect("/Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/BuscarDoctor.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/PanelConsultaS.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/AgendarHora.aspx");
        }
    }
}