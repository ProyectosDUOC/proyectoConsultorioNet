using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb
{
    public partial class Login : System.Web.UI.Page
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

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
          //  string user = Request.Form["txtUsuario"];
          //  string pass = Request.Form["txtPass"];

           // ControlAcceso controlAcceso = new ControlAcceso();           

            controlAcceso.Username = txtUsuario.Text;
            if (controlAcceso.Read())
            {            
                if (controlAcceso.Activo == 1)
                {
                    if (controlAcceso.Pass.Equals(txtPass.Text))
                    {
                        Session["usuario"] = controlAcceso;

                        if (controlAcceso.IdTipoUsuario == 2)
                        {
                            Response.Redirect("Secretaria/MenuSecretaria.aspx");
                        }
                        if (controlAcceso.IdTipoUsuario == 3)
                        {
                            Response.Redirect("Enfermera/PanelConsultaE.aspx");
                        }
                        if (controlAcceso.IdTipoUsuario == 4)
                        {
                            Response.Redirect("Medico/PanelConsultaM.aspx");
                        }
                        if (controlAcceso.IdTipoUsuario == 5)
                        {
                            Response.Redirect("Admin/Administrador.aspx");
                            //Response.Redirect("/Admin/Administrador.aspx?login="+login);
                        }
                    }
                    else
                    {
                        lblMensaje.Text = "Clave incorrecta";
                    }
                }
                else
                {
                    lblMensaje.Text = "Usuario fue eliminado";
                }
            }
            else {
                lblMensaje.Text = "Usuario no existe";
            }            
        }
    }
}