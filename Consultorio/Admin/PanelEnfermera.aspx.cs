using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio.Admin
{
    public partial class PanelEnfermera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Enfermera/AgregarEnfermera.aspx");
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Enfermera/BuscarEnfermera.aspx");
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Enfermera/ModificarEnfermera.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Enfermera/EliminarEnfermera.aspx");
        }

        protected void btn_Listar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Enfermera/ListarEnfermera.aspx");
        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/Administrador.aspx");
        }
    }
}