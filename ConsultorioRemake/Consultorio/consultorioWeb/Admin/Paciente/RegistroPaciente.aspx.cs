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
                if (controlAcceso.Id == 0)
                {
                    Response.Redirect("/Login.aspx");
                }
            }
        }
        
        protected void btn_Buscar_Click(object sender, EventArgs e)
        {            
            Usuario usuario = new Usuario();           
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);     
            if (usuario.ReadRut())
            {
                if (usuario.Dv == Convert.ToChar(txt_dv.Text))
                {               
                   capaNegocio.Paciente paciente = new capaNegocio.Paciente();
                    paciente.IdUsuario = usuario.Id;
                    if (paciente.ReadIdUsuario())
                    {
                        txt_pNombre.Text = usuario.Pnombre;
                        txt_sNombre.Text = usuario.Snombre;
                        txt_apMaterno.Text = usuario.Apmaterno;
                        txt_apPaterno.Text = usuario.Appaterno;
                        txt_Fecha.Text = usuario.FechaNacimiento.ToString("yyyy-MM-dd");
                        //Seleccion la id del selectIndex
                        ddGenero.SelectedIndex = ddGenero.Items.IndexOf(ddGenero.Items.FindByValue(usuario.IdGenero.ToString()));
                        ddNacionalidad.SelectedIndex = ddNacionalidad.Items.IndexOf(ddNacionalidad.Items.FindByValue(usuario.IdNacionalidad.ToString()));
                        txt_Domicilio.Text = usuario.Direccion;
                        ddComuna.SelectedIndex = ddComuna.Items.IndexOf(ddComuna.Items.FindByValue(usuario.IdComuna.ToString()));
                        //Calcula la edad 
                        lblAnios.Text = (DateTime.Today.AddTicks(- usuario.FechaNacimiento.Ticks).Year - 1).ToString();
                        txt_fono1.Text = usuario.Fono1;
                        txt_fono2.Text = usuario.Fono2;

                        txt_nFicha.Text = paciente.Id.ToString();
                        ddSector.SelectedIndex = ddSector.Items.IndexOf(ddSector.Items.FindByValue(paciente.IdSector.ToString()));

                        ddGrupoS.SelectedIndex = ddGrupoS.Items.IndexOf(ddGrupoS.Items.FindByValue(paciente.IdGrupoSanguineo.ToString()));
                        ddRh.SelectedIndex = ddRh.Items.IndexOf(ddRh.Items.FindByValue(paciente.IdRh.ToString()));
                        lblRespuesta.Text = usuario.FechaNacimiento.ToString();
                        desbloqueo();
                        btnGuardarActualizar.Enabled = true;
                        btnAgregar.Enabled = false;
                    }
                    else
                    {
                        lblRespuesta.Text = "No entro al paciente";
                    }
                }
                else {
                    lblRespuesta.Text = "DV invalido";
                }
                
            }
            else {
                lblRespuesta.Text = "Usuario no Registrado";                
                limpiar();              
                bloqueo();
                btnHabilitar.Enabled = true;
                btnHabilitar.Visible = true;
                           
            }
        }
        private void desbloqueo() {           
            PContenido.Enabled = true;
        }
        private void bloqueo() {
            PContenido.Enabled = false;
            btnGuardarActualizar.Enabled = false;           
            btnAgregar.Enabled = false;           
            txt_nFicha.Enabled = false;
            btnHabilitar.Visible = false;
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

        protected void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Rut = Convert.ToInt32(txt_Rut.Text);
            if (us.ReadRut()) //Caso que usuario Existe se actualiza
            {
                capaNegocio.Paciente pac = new capaNegocio.Paciente();
                pac.IdUsuario = us.Id;
                if (pac.ReadIdUsuario())
                {
                    pac.IdGrupoSanguineo = ddGrupoS.SelectedIndex + 1;
                    pac.IdRh = ddRh.SelectedIndex + 1;
                    pac.IdSector = ddRh.SelectedIndex + 1;
                    us.Pnombre = txt_pNombre.Text;
                    us.Snombre = txt_sNombre.Text;
                    us.Appaterno = txt_apPaterno.Text;
                    us.Apmaterno = txt_apMaterno.Text;
                    us.FechaNacimiento = Convert.ToDateTime(txt_Fecha.Text);
                    us.IdGenero = ddGenero.SelectedIndex + 1;
                    us.IdNacionalidad = ddNacionalidad.SelectedIndex + 1;
                    us.Direccion = txt_Domicilio.Text;
                    us.IdComuna = ddComuna.SelectedIndex + 1;
                    lblAnios.Text = (DateTime.Today.AddTicks(- us.FechaNacimiento.Ticks).Year - 1).ToString();
                    us.Fono1 = txt_fono1.Text;
                    us.Fono2 = txt_fono2.Text;

                    if (us.UpdateNuevo())
                    {
                        if (pac.Update())
                        {
                            lblRespuesta.Text = "se ha actualizado Paciente";
                        }
                    }
                    else { 
                        lblRespuesta.Text = "Error al actualizar";
                    }
                }            
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();       
            us.Rut = Convert.ToInt32(txt_Rut.Text);
            
            if (us.ReadRut())
	        {
		        lblRespuesta.Text = "No se puede agregar usuario ya existe";
	        }
            else{
                capaNegocio.Paciente pac = new capaNegocio.Paciente();
                int contadoU = capaNegocio.Control.Contadores.contadorIdUsuario();
                int contadoP = capaNegocio.Control.Contadores.contadorIdPaciente();
                try 
	            {	        
		            us.Id = contadoU + 1;                    
                    us.Dv = Convert.ToChar(txt_dv.Text);
                    us.Pnombre = txt_pNombre.Text;
                    us.Snombre = txt_sNombre.Text;
                    us.Appaterno = txt_apPaterno.Text;
                    us.Apmaterno = txt_apMaterno.Text;
                    us.FechaNacimiento =  Convert.ToDateTime(txt_Fecha.Text);
                    us.IdGenero = ddGenero.SelectedIndex + 1;
                    us.IdNacionalidad = ddNacionalidad.SelectedIndex + 1;
                    us.Direccion = txt_Domicilio.Text;
                    us.IdComuna =  ddComuna.SelectedIndex + 1;                    
                    lblAnios.Text = (DateTime.Today.AddTicks(-us.FechaNacimiento.Ticks).Year - 1).ToString();
                    us.Fono1 = txt_fono1.Text;
                    us.Fono2 = txt_fono2.Text;
                    if (us.Create())
	                {
		                pac.Id = contadoP +1;
                        pac.IdUsuario = us.Id;
                        pac.IdGrupoSanguineo = ddGrupoS.SelectedIndex + 1;
                        pac.IdRh = ddRh.SelectedIndex + 1;
                        pac.IdSector = ddRh.SelectedIndex + 1;
                        if (pac.Create())
	                    {
		                    lblRespuesta.Text = "Paciente creado. Id de ficha: "+pac.Id;
                            txt_nFicha.Text = pac.Id.ToString();
	                    }
                        else{
                             lblRespuesta.Text = "Paciente no creado";
                        }
	                }
                    else{
                        lblRespuesta.Text = "Usuario no creado";
                    }                   

	            }
	            catch (Exception ex)
	            {		
		            lblRespuesta.Text = ex.Message;
	            }
            }
                      

        }

        protected void btnHabilitar_Click1(object sender, EventArgs e)
        {
            desbloqueo();
            btnAgregar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnHabilitar.Visible = false;
        }   
    }
}