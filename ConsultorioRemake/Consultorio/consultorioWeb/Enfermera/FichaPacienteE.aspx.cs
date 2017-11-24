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

                if (ficha.IdEnfermera != 0)
                {
                    txtPeso.Text = ficha.Peso.ToString();
                    txtEstatura.Text = ficha.Estatura.ToString();
                    txtTemperatura.Text = ficha.Temperatura.ToString();
                    txtDia.Text = ficha.Diastolica.ToString();
                    txtSys.Text = ficha.Sistonica.ToString();
                    txtPulsaciones.Text = ficha.Pulsacion.ToString();
                    IMC.Text = ficha.Imc;
                }
                if (controlAcceso.IdUsuario==0)
                {
                    Response.Redirect("/Login.aspx");
                }

                
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int idficha = Convert.ToInt32(Request.Params["id"]);
            FichaPaciente ficha = new FichaPaciente();
            ficha.Id_ficha_paciente = idficha;
            ficha.Read();
            try
            {
                ficha.Peso = Convert.ToInt32(txtPeso.Text);
                ficha.Estatura = Convert.ToInt32(txtEstatura.Text);
                int kg = Convert.ToInt32(txtPeso.Text);
                double alto = (ficha.Estatura / 100.0);
                double resultado = (kg / (alto * alto));
                IMC.Text = resultado.ToString();
                ficha.Imc = resultado.ToString();
                ficha.Temperatura = Convert.ToInt32(txtTemperatura.Text);
                ficha.Diastolica = Convert.ToInt32(txtDia.Text);
                ficha.Sistonica = Convert.ToInt32(txtSys.Text);
                ficha.Pulsacion = Convert.ToInt32(txtPulsaciones.Text);
                ficha.Motivo = txtMotivo.Text;
                //Busco a la enfermera               
                capaNegocio.Enfermera enfe = new capaNegocio.Enfermera();
                enfe.IdUsuario = controlAcceso.IdUsuario;
                enfe.ReadUsuarioId();
                ficha.IdEnfermera = enfe.Id;

                if (ficha.Update())
                {

                    lblEstado.Text = "Registrado";
                }
                else
                {
                    lblEstado.Text = "No se ha podido Registrar";
                }
            }
            catch (Exception ex)
            {
                lblEstado.Text = ex.Message;
            }
        }
        
    }
}