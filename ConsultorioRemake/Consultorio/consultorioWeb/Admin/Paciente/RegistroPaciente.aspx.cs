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
                ddGenero.DataSource = capaNegocio.GeneroColeccion.ReadAll();
                ddGenero.DataBind();
                ddNacionalidad.DataSource = capaNegocio.NacionalidadColeccion.ReadAll();
                ddNacionalidad.DataBind();
                ddComuna.DataSource = capaNegocio.ComunaColeccion.ReadAll();
                ddComuna.DataBind();
                ddSector.DataSource = capaNegocio.SectorColeccion.ReadAll();
                ddSector.DataBind();
                ddRh.DataSource = capaNegocio.Rh_sanguineoColeccion.ReadAll();
                ddRh.DataBind();
                ddGrupoS.DataSource = capaNegocio.GrupoSanguineoColeccion.ReadAll();
                ddGrupoS.DataBind();

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
         
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);
            usuario.Dv = Convert.ToChar(txt_dv.Text);

    //DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByValue(miValor));

            if (usuario.ReadRut())
            {
                
                paciente.IdUsuario = usuario.Id;

                if (paciente.ReadIdUsuario()) {
                    txt_pNombre.Text = usuario.Pnombre;
                    txt_sNombre.Text = usuario.Snombre;
                    txt_apMaterno.Text = usuario.Apmaterno;
                    txt_apPaterno.Text = usuario.Appaterno;
                    txt_Fecha.Text = usuario.FechaNacimiento.ToShortDateString();//falla fecha

                    //Calcula la edad 
                    lblAnios.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();

                    //Seleccion la id del selectIndex
                    ddGenero.SelectedIndex = ddGenero.Items.IndexOf(ddGenero.Items.FindByValue(usuario.IdGenero.ToString()));
                    ddNacionalidad.SelectedIndex = ddNacionalidad.Items.IndexOf(ddNacionalidad.Items.FindByValue(usuario.IdNacionalidad.ToString()));
                    txt_Domicilio.Text = usuario.Direccion;
                    ddComuna.SelectedIndex = ddComuna.Items.IndexOf(ddComuna.Items.FindByValue(usuario.IdComuna.ToString()));
                    ddSector.SelectedIndex = ddSector.Items.IndexOf(ddSector.Items.FindByValue(paciente.IdSector.ToString()));
                    txt_fono1.Text = usuario.Fono1;
                    txt_fono2.Text = usuario.Fono2;
                    ddGrupoS.SelectedIndex = ddGrupoS.Items.IndexOf(ddGrupoS.Items.FindByValue(paciente.IdGrupoSanguineo.ToString()));
                    ddRh.SelectedIndex = ddRh.Items.IndexOf(ddRh.Items.FindByValue(paciente.IdRh.ToString()));


                    desbloqueo();
                    lblRespuesta.Text = "se encontro" + usuario.Id;                
                }

                lblRespuesta.Text = "no exite paciente";
                limpiar();
                bloqueo();
            }
            else {
                lblRespuesta.Text = "No se encontro";
                limpiar();
                bloqueo();
            }

        }
        private void desbloqueo() {
            txt_Fecha.Enabled = true;
            txt_apMaterno.Enabled = true;
            txt_fono2.Enabled = true;
            txt_nFicha.Enabled = true;
            txt_pNombre.Enabled = true;
            txt_sNombre.Enabled = true;
            txt_apPaterno.Enabled = true;
            txt_Domicilio.Enabled = true;
            txt_fono1.Enabled = true;
            ddGenero.Enabled = true;
            ddComuna.Enabled = true;
            ddGrupoS.Enabled = true;
            ddNacionalidad.Enabled = true;
            ddRh.Enabled = true;
            ddSector.Enabled = true;
            btn_Guardar.Enabled = true;
        
        }
        private void bloqueo() {
            txt_Fecha.Enabled = false;
            txt_apMaterno.Enabled = false;
            txt_fono1.Enabled = false;
            txt_nFicha.Enabled = false;
            txt_pNombre.Enabled = false;
            txt_sNombre.Enabled = false;
            txt_apPaterno.Enabled = false;
            txt_Domicilio.Enabled = false;
            txt_fono2.Enabled = false;
            ddGenero.Enabled = false;
            ddComuna.Enabled = false;
            ddGrupoS.Enabled = false;
            ddNacionalidad.Enabled = false;
            ddRh.Enabled = false;
            ddSector.Enabled = false;
            btn_Guardar.Enabled = false;
        }
        private void limpiar() {
            txt_Fecha.Text = "" ;
            txt_apMaterno.Text = "";
            txt_fono1.Text = "";
            txt_nFicha.Text = "";
            txt_pNombre.Text = "";
            txt_sNombre.Text = "";
            txt_apPaterno.Text = "";
            txt_Domicilio.Text = "";
            txt_fono2.Text = "";
        
        
        
        }

        protected void btn_Guardar_Click(object sender, EventArgs e)
        {

        }
    }
}