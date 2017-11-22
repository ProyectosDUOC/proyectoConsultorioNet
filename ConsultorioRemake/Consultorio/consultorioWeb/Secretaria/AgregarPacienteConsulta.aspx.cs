using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Secretaria
{
    public partial class AgregarPacienteConsulta : System.Web.UI.Page
    {
        Paciente paciente = new Paciente();
        Usuario usuario = new Usuario();
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
                invisible();
            }
           
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
           usuario.Rut = Convert.ToInt32(txt_Rut.Text);

            if (usuario.ReadRut())
            {
                if (usuario.Dv.ToString().Equals(txt_dv.Text))
                {

                    capaNegocio.ClasesListar.PacienteListar pac= new capaNegocio.ClasesListar.PacienteListar();

                    pac = capaNegocio.ClasesListar.PacienteLColeccion.BuscarCompleto(usuario.Id);


                    visible();


                   
                    paciente.IdUsuario = usuario.Id;

                    ln.Text = paciente.Id.ToString();
                    lnombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
                    
                    Nacionalidad nacio = new Nacionalidad();
                    nacio.Id = usuario.IdNacionalidad;
                    nacio.Read();
                    lNacionalidad.Text = nacio.Nombre;
                    lfecha.Text = usuario.FechaNacimiento.ToString();
                    lf1.Text = usuario.Fono1;
                    lf2.Text = usuario.Fono2;
                    ledad.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();
                    lDomicilio.Text = usuario.Direccion;
                    lComuna.Text = pac.Comuna;
                    lSector.Text = pac.Sector;
                    lGrupoS.Text = pac.GrupoSanguineo;
                    lRsan.Text = pac.Rh;
                    txtArea.Text = "";

                }
            }
            else {
                txtArea.Text = "No se encontro paciente";
                invisible();
            }
        }
        private void visible() {
            ln.Enabled = true;
            lnombre.Enabled = true;
            lNacionalidad.Enabled = true;
            lfecha.Enabled = true;
            lf1.Enabled = true;
            lf2.Enabled = true;
            ledad.Enabled = true;
            lDomicilio.Enabled = true;
            lComuna.Enabled = true;
            lSector.Enabled = true;
            lGrupoS.Enabled = true;
            lRsan.Enabled = true;
        }
        private void invisible() {
            ln.Enabled = false;
            lnombre.Enabled= false;
            lNacionalidad.Enabled = false;
            lfecha.Enabled = false;
            lf1.Enabled = false;
            lf2.Enabled = false;
            ledad.Enabled = false;
            lDomicilio.Enabled = false;
            lComuna.Enabled = false;
            lSector.Enabled = false;
            lGrupoS.Enabled = false;
            lRsan.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FichaPaciente fichaPaciente = new FichaPaciente();

            fichaPaciente.Id_ficha_paciente = paciente.Id;
            capaNegocio.Secretaria secre = new capaNegocio.Secretaria();
            secre.IdUsuario = controlAcceso.IdUsuario;

            if (secre.ReadId()) {
                fichaPaciente.IdSecretaria = secre.Id;
                fichaPaciente.Motivo = txtArea.Text;
                fichaPaciente.IdConsultorio = 1;

                if (fichaPaciente.Create())
                {
                    lblRespuesta.Text = "Se ha generado La ficha";
                }
                else
                {
                    lblRespuesta.Text = "No se ha creado !!" + fichaPaciente.ToString();
                }
            }
            else{
                lblRespuesta.Text = "No se encontro secre";
            }
            
            
            
           
        }
    }
}