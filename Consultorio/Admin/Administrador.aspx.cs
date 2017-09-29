using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Clases;

namespace Consultorio.Admin
{
    public partial class Administrador : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_Paciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelPaciente.aspx");
        }

        protected void btn_Enfermera_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }

        protected void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        protected void btn_Medico_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelMedico.aspx");
        }

        protected void btn_Secretaria_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelSecretaria.aspx");
        }
    }
}