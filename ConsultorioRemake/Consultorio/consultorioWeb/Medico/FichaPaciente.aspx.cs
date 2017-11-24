using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Medico
{
    public partial class FichaPaciente : System.Web.UI.Page
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

            if (Request.Params["id"] != null)
            {
                int id = Convert.ToInt32(Request.Params["id"]);
                capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();

                ficha.Id_ficha_paciente = id;
                ficha.Read();

                capaNegocio.Paciente pac = new capaNegocio.Paciente();
                pac.Id = ficha.IdPaciente;
                pac.Read();

                capaNegocio.Usuario usuario = new capaNegocio.Usuario();
                usuario.Id = pac.IdUsuario;
                usuario.Read();
                lblNombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
                lblRut.Text = usuario.Rut + "-" + usuario.Dv;
                lblMotivo.Text = ficha.Motivo;
                lblPeso.Text = ficha.Peso.ToString();
                lblEstatura.Text = ficha.Estatura.ToString();
                lblTemperatura.Text = ficha.Temperatura.ToString();
                lblDia.Text = ficha.Diastolica.ToString();
                lblSys.Text = ficha.Sistonica.ToString();
                lblPul.Text = ficha.Pulsacion.ToString();
                IMC.Text = ficha.Imc;

                if (ficha.IdMedico != 0)
                {
                    txtDiagnostico.Text = ficha.Diagnostico;
                }

                else
                {
                    Response.Redirect("/PanelConsultaM.aspx");
                }
            }
         
            if (controlAcceso.Id==0)
            {
                Response.Redirect("/login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}