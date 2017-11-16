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


        protected void btn_Buscar_Click(object sender, EventArgs e)
        {            
            Usuario usuario = new Usuario();
            
         
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);          

    //DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByValue(miValor));

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
                        lblAnios.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();
                        txt_fono1.Text = usuario.Fono1;
                        txt_fono2.Text = usuario.Fono2;

                        txt_nFicha.Text = paciente.Id.ToString();
                        ddSector.SelectedIndex = ddSector.Items.IndexOf(ddSector.Items.FindByValue(paciente.IdSector.ToString()));

                        ddGrupoS.SelectedIndex = ddGrupoS.Items.IndexOf(ddGrupoS.Items.FindByValue(paciente.IdGrupoSanguineo.ToString()));
                        ddRh.SelectedIndex = ddRh.Items.IndexOf(ddRh.Items.FindByValue(paciente.IdRh.ToString()));
                        //lblRespuesta.Text = "no exite paciente";
                        lblRespuesta.Text = usuario.FechaNacimiento.ToString();
                        desbloqueo();
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
                btnHabilitar.Visible = true;                
            }
        }
        private void desbloqueo() {
            txt_Fecha.Enabled = true;
            txt_apMaterno.Enabled = true;
            txt_fono2.Enabled = true;
           // txt_nFicha.Enabled = true;
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
            btnGuardarActualizar.Enabled = true;
            btnHabilitar.Visible = true;
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
            btnGuardarActualizar.Enabled = false;
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



/*
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);

            if (usuario.ReadRut()) //si existe entonces se agrega, si no existe se actualiza :3
            {
                if (usuario.Dv == Convert.ToChar(txt_dv.Text))
                {
                    capaNegocio.Paciente paciente = new capaNegocio.Paciente();
                    paciente.IdUsuario = usuario.Id;
                    if (paciente.ReadIdUsuario()) 
                    {
                        usuario.Pnombre = txt_pNombre.Text;
                        usuario.Snombre = txt_sNombre.Text;
                        usuario.Apmaterno = txt_apMaterno.Text;
                        usuario.Appaterno = txt_apPaterno.Text;
                        usuario.FechaNacimiento = Convert.ToDateTime(txt_Fecha.Text);
                        usuario.IdGenero = ddGenero.SelectedIndex;
                        usuario.IdNacionalidad = ddNacionalidad.SelectedIndex;
                        usuario.Direccion = txt_Domicilio.Text;
                        usuario.IdComuna = ddComuna.SelectedIndex;                      
                        lblAnios.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();

                        usuario.Fono1 = txt_fono1.Text;
                        usuario.Fono2 = txt_fono2.Text;

                        paciente.IdSector = ddSector.SelectedIndex;
                        paciente.IdGrupoSanguineo = ddGrupoS.SelectedIndex;
                        paciente.IdRh = ddRh.SelectedIndex;
                        //lblRespuesta.Text = "no exite paciente";

                        if (paciente.Update())
                        {
                            if (usuario.Update())
                            {
                                lblRespuesta.Text = "0";
                            }
                            lblRespuesta.Text = "1";
                        }
                       
                    }
                    else
                    {
                        lblRespuesta.Text = "2";
                    }
                }
                else
                {
                    lblRespuesta.Text = "3";
                }

            }
            else
            {
                lblRespuesta.Text = "Usuario no Registrado";
                limpiar();
                btnHabilitar.Visible = true;
            }
        } */

        protected void btnHabilitar_Click(object sender, EventArgs e)
        {
            desbloqueo();
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
                    pac.IdGrupoSanguineo = ddGrupoS.SelectedIndex;
                    pac.IdRh = ddRh.SelectedIndex;
                    pac.IdSector = ddRh.SelectedIndex;

                    us.Pnombre = txt_pNombre.Text;
                    us.Snombre = txt_sNombre.Text;
                    us.Appaterno = txt_apPaterno.Text;
                    us.Apmaterno = txt_apMaterno.Text;
                    us.FechaNacimiento = Convert.ToDateTime(txt_Fecha.Text);
                    us.IdGenero = ddGenero.SelectedIndex;
                    us.IdNacionalidad = ddNacionalidad.SelectedIndex;
                    us.Direccion = txt_Domicilio.Text;
                    us.IdComuna = ddComuna.SelectedIndex;
                    lblAnios.Text = (DateTime.Today.AddTicks(-us.FechaNacimiento.Ticks).Year - 1).ToString();
                    us.Fono1 = txt_fono1.Text;
                    us.Fono2 = txt_fono2.Text;

                    lblRespuesta.Text = us.imprimir() + "xx";
                    if (us.UpdateNuevo())
                    {
                        if (pac.Update())
                        {
                            lblRespuesta.Text = "Exito!. Se ha actualizado";
                        }
                        else {
                            lblRespuesta.Text = "Erooorororooror";
                        }
                    }
                    else {
                        lblRespuesta.Text = "No se actualizo";
                    }
                    
                }

            }   //Caso usuario no exite se agrega
            else {
                lblRespuesta.Text = "Se crea";            
            }
        }   
    }
}