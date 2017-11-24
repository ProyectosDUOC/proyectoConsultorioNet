using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Enfermera
{
    public partial class FichaPacienteE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null) {
                int id = Convert.ToInt32(Request.Params["id"]);
                FichaPaciente ficha = new FichaPaciente();

                ficha.Id_ficha_paciente = id;
                ficha.Read();

                Paciente pac = new Paciente();
                pac.Id = ficha.IdPaciente;
                pac.Read();

                Usuario usuario = new Usuario();
                usuario.Id = pac.IdUsuario;
                usuario.Read();

                lblNombre.Text = usuario.Pnombre +" "+ usuario.Snombre+" "+usuario.Appaterno+" "+usuario.Apmaterno;
                lblRut.Text = usuario.Rut + "-" + usuario.Dv;
                txtMotivo.Text = ficha.Motivo;

                
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}