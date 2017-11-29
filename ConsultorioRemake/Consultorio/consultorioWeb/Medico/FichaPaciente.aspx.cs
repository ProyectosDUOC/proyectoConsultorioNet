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
            if (!IsPostBack)
            {
                if (Request.Params["id"] != null)
                {
                    int id = Convert.ToInt32(Request.Params["id"]);
                    capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();

                    GridView1.DataSource = capaNegocio.ClasesListar.RecetaMedicametosColeecion.generalListado(id);
                    GridView1.DataBind();

                    ficha.Id_ficha_paciente = id;
                    ficha.Read();
                    lblID.Text = id.ToString();
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

                    if (ficha.IdMedico > 0)
                    {
                        txtDiagnostico.Text = ficha.Diagnostico;
                    }
                }
            }
           
         
            if (controlAcceso.Id==0)
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            int idficha = Convert.ToInt32(Request.Params["id"]);
            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Id_ficha_paciente = idficha;
            ficha.Read();
            try
            {                
                capaNegocio.Medico medico = new capaNegocio.Medico();
                medico.IdUsuario = controlAcceso.IdUsuario;
                medico.ReadIdUsuario();

                ficha.IdMedico = medico.Id;
                ficha.Diagnostico = txtDiagnostico.Text;

                if (ficha.Update())
                {

                    lblMensaje.Text = "Consulta Finalizada";
                }
                else
                {
                    lblMensaje.Text = "No se ha podido Registrar";
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            lblMensaje.Text = "No se ha podido Registrar";
        }

        protected void btnMedicamentos_Click(object sender, EventArgs e)
        {
            String idFicha = lblID.Text;
            Response.Redirect("Medico/RecetaMedica.aspx?id="+idFicha);
        }
    }
}