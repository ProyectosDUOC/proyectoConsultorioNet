using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Admin.Paciente
{
    public partial class RegistroPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bloqueo();
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelPaciente.aspx");
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {            
            Usuario usuario = new Usuario();
            capaNegocio.Paciente paciente = new capaNegocio.Paciente();
            capaNegocio.Nacionalidad nacionalidad = new capaNegocio.Nacionalidad();
            capaNegocio.Sector sector = new Sector();
            capaNegocio.Comuna comuna = new Comuna();
            capaNegocio.Rh_sanguineo rhS = new Rh_sanguineo();
            capaNegocio.GrupoSanguineo gS = new GrupoSanguineo();

            usuario.Rut = Convert.ToInt32(txt_Rut.Text);
            usuario.Dv = Convert.ToChar(txt_dv.Text);

            if (usuario.Read())
            {
                paciente.IdUsuario = usuario.Id;

                paciente.Read();

                txt_sNombre.Text = usuario.Pnombre;


            }
            else { 
                
            }

        }

        private void bloqueo() {
            txt_Fecha.Enabled = false;
            txt_apMaterno.Enabled = false;
            txt_nCasa.Enabled = false;
            txt_nFicha.Enabled = false;
            txt_pNombre.Enabled = false;
            txt_sNombre.Enabled = false;
        
        }
    }
}