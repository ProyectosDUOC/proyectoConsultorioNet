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
        capaNegocio.ClasesListar.PacienteListar pac = new capaNegocio.ClasesListar.PacienteListar();
    
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
            invisible();
           
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
           usuario.Rut = Convert.ToInt32(txt_Rut.Text);

            if (usuario.ReadRut())
            {
                if (usuario.Dv.ToString().Equals(txt_dv.Text))
                {

                    pac = capaNegocio.ClasesListar.PacienteLColeccion.BuscarCompleto(usuario.Id);
                    visible();                   
                    paciente.IdUsuario = usuario.Id;
                    paciente.ReadIdUsuario();
                    ln.Text = paciente.Id.ToString();
                    lnombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
                    Nacionalidad nacio = new Nacionalidad();
                    nacio.Id = usuario.IdNacionalidad;
                    nacio.Read();
                    lNacionalidad.Text = nacio.Nombre;
                    lfecha.Text = usuario.FechaNacimiento.ToString();
                    lf1.Text = usuario.Fono1;
                    lf2.Text = usuario.Fono2;
                    Genero gener = new Genero();
                    gener.Id = usuario.IdGenero;
                    gener.Read();
                    lGenero.Text = gener.Nombre;
                    ledad.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();
                    lDomicilio.Text = usuario.Direccion;
                    lComuna.Text = pac.Comuna;
                    lSector.Text = pac.Sector;
                    lGrupoS.Text = pac.GrupoSanguineo;
                    lRsan.Text = pac.Rh;
                    txtArea.Text = "";
                    lblRespuesta.Text = "id del paciente"+pac.Id.ToString();

                }
            }
            else {
                txtArea.Text = "No se encontro paciente";
                invisible();
            }
        }
        private void visible() {
            panel1.Visible = true;
            
        }
        private void invisible() {
            panel1.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            FichaPaciente fichaPaciente = new FichaPaciente();
            

            int contador = capaNegocio.Control.Contadores.contadorIdFichaPaciente();          
            fichaPaciente.Id_ficha_paciente = contador + 1;

            usuario.Rut = Convert.ToInt32(txt_Rut.Text);
            usuario.ReadRut();
            pac = capaNegocio.ClasesListar.PacienteLColeccion.BuscarCompleto(usuario.Id);
            fichaPaciente.IdPaciente = pac.Id;
   
            fichaPaciente.Motivo = txtArea.Text;
            fichaPaciente.IdConsultorio = 1;

            if (fichaPaciente.Create())
            {
                lblRespuesta.Text = "Se ha generado La ficha !!!! " + pac.Id;
            }
            else
            {
                lblRespuesta.Text = "No se ha creado !!" + fichaPaciente.ToString();
            } 
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int contador = capaNegocio.Control.Contadores.contadorIdFichaPaciente();
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);
            usuario.ReadRut();
            pac = capaNegocio.ClasesListar.PacienteLColeccion.BuscarCompleto(usuario.Id);

            lblRespuesta.Text = pac.Id.ToString();
        }
    }
}