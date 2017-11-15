using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio.Admin
{
    public partial class PanelSecretaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Agregar_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/AgregarSecretaria.aspx");

        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/BuscarSecretaria.aspx");
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/ModificarSecretaria.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/EliminarSecretaria.aspx");
        }

        protected void btn_Listar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Secretaria/ListarSecretaria.aspx");
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Administrador.aspx");
        }
    }
}