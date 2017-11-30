using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Admin.Enfermera
{
    public partial class RegistroEnfermera : System.Web.UI.Page
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
                ddNacionalidad.DataSource = capaNegocio.NacionalidadColeccion.ReadAll();
                ddComuna.DataSource = capaNegocio.ComunaColeccion.ReadAll();

                ddGenero.DataBind();
                ddNacionalidad.DataBind();
                ddComuna.DataBind();
                if (controlAcceso.Id == 0)
                {
                    Response.Redirect("../../Login.aspx");
                }
            }

        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PanelEnfermera.aspx");
        }

        private void bloqueo()
        {
            txt_pNombre.Enabled = false;
            txt_sNombre.Enabled = false;
            txt_apPaterno.Enabled = false;
            txt_apMaterno.Enabled = false;
            txt_Fecha.Enabled = false;
            ddGenero.Enabled = false;
            ddNacionalidad.Enabled = false;
            txt_Domicilio.Enabled = false;
            ddComuna.Enabled = false;
            txt_nCasa.Enabled = false;
            txt_nCelular.Enabled = false;
            btnGuardarActualizar.Enabled = false;
            btn_Agregar.Enabled = false;
            btnHabilitar.Visible = false;
        }

        private void desbloqueo()
        {
            txt_pNombre.Enabled = true;
            txt_sNombre.Enabled = true;
            txt_apPaterno.Enabled = true;
            txt_apMaterno.Enabled = true;
            txt_Fecha.Enabled = true;
            ddGenero.Enabled = true;
            ddNacionalidad.Enabled = true;
            txt_Domicilio.Enabled = true;
            ddComuna.Enabled = true;
            txt_nCasa.Enabled = true;
            txt_nCelular.Enabled = true;
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Rut = Convert.ToInt32(txt_Rut.Text);

            if (usuario.ReadRut())
            {
                capaNegocio.Enfermera enfermera = new capaNegocio.Enfermera();
                enfermera.IdUsuario = usuario.Id;
                if (enfermera.ReadUsuarioId())
                {
                    txt_dv.Text = usuario.Dv.ToString();
                    txt_pNombre.Text = usuario.Pnombre;
                    txt_sNombre.Text = usuario.Snombre;
                    txt_apMaterno.Text = usuario.Apmaterno;
                    txt_apPaterno.Text = usuario.Appaterno;
                    txt_Fecha.Text = usuario.FechaNacimiento.ToString("yyyy-MM-dd");
                    lbl_Edad.Text = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();
                    txt_Domicilio.Text = usuario.Direccion;
                    txt_nCasa.Text = usuario.Fono1;
                    txt_nCelular.Text = usuario.Fono2;

                    ddGenero.SelectedIndex = ddGenero.Items.IndexOf(ddGenero.Items.FindByValue(usuario.IdGenero.ToString()));
                    ddNacionalidad.SelectedIndex = ddNacionalidad.Items.IndexOf(ddNacionalidad.Items.FindByValue(usuario.IdNacionalidad.ToString()));
                    ddComuna.SelectedIndex = ddComuna.Items.IndexOf(ddComuna.Items.FindByValue(usuario.IdComuna.ToString()));
                    desbloqueo();
                    btnGuardarActualizar.Enabled = true;
                    btn_Agregar.Enabled = false;
                }
                else
                {
                    lblRespuesta.Text = "No entro enfermera ";
                }
            }
            else
            {
                lblRespuesta.Text = "No se encontro";
                limpiar();
                bloqueo();
                btnHabilitar.Enabled = true;
                btnHabilitar.Visible = true;
            }
        }

        private void limpiar()
        {
            txt_pNombre.Text = "";
            txt_sNombre.Text = "";
            txt_apPaterno.Text = "";
            txt_apMaterno.Text = "";
            txt_Fecha.Text = "";
            txt_Domicilio.Text = "";
            txt_nCasa.Text = "";
            txt_nCelular.Text = "";
        }

        protected void btnHabilitar_Click1(object sender, EventArgs e)
        {
            desbloqueo();
            btn_Agregar.Enabled = true;
            btnHabilitar.Enabled = false;
            btnHabilitar.Visible = false;
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rut = Convert.ToInt32(txt_Rut.Text);

            if (user.ReadRut())
            {
                lblRespuesta.Text = "No se puede agregar usuario ya existe";
            } 
            else
            {
                capaNegocio.Enfermera enf = new capaNegocio.Enfermera();
                int contadorU = capaNegocio.Control.Contadores.contadorIdUsuario();
                int contadorE = capaNegocio.Control.Contadores.contadorIdEnfemera();

                try
                {
                    user.Id = contadorU + 1;
                    user.Dv = Convert.ToChar(txt_dv.Text);
                    user.Pnombre = txt_pNombre.Text;
                    user.Snombre = txt_sNombre.Text;
                    user.Appaterno = txt_apPaterno.Text;
                    user.Apmaterno = txt_apMaterno.Text;
                    user.FechaNacimiento = Convert.ToDateTime(txt_Fecha.Text);
                    user.IdGenero = ddGenero.SelectedIndex + 1;
                    user.IdNacionalidad = ddNacionalidad.SelectedIndex + 1;
                    user.Direccion = txt_Domicilio.Text;
                    user.IdComuna = ddComuna.SelectedIndex + 1;
                    lbl_Edad.Text = (DateTime.Today.AddTicks(-user.FechaNacimiento.Ticks).Year - 1).ToString();
                    user.Fono1 = txt_nCasa.Text;
                    user.Fono2 = txt_nCelular.Text;
                    if (user.Create())
                    {
                        enf.Id = contadorE + 1;
                        enf.IdUsuario = user.Id;
                        //enf.IdJornadaLaboral = ;
                        if (enf.Create())
                        {
                            lblRespuesta.Text = "Exito! Se ha creado";
                        }
                    }
                    else
                    {
                        lblRespuesta.Text = "No ha sido creado";
                    }
                }
                catch (Exception ex)
                {
                    lblRespuesta.Text = ex.Message;
                }
            }
        }

        protected void btnGuardarActualizar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Rut = Convert.ToInt32(txt_Rut.Text);

            if (user.ReadRut())
            {
                capaNegocio.Enfermera enfermera = new capaNegocio.Enfermera();
                enfermera.IdUsuario = user.Id;

                if (enfermera.ReadUsuarioId())
                {
                    user.Pnombre = txt_pNombre.Text;
                    user.Snombre = txt_sNombre.Text;
                    user.Appaterno = txt_apPaterno.Text;
                    user.Apmaterno = txt_apMaterno.Text;
                    user.FechaNacimiento = Convert.ToDateTime(txt_Fecha.Text);
                    user.IdGenero = ddGenero.SelectedIndex + 1;
                    user.IdNacionalidad = ddNacionalidad.SelectedIndex + 1;
                    user.Direccion = txt_Domicilio.Text;
                    user.IdComuna = ddComuna.SelectedIndex + 1;
                    lbl_Edad.Text = (DateTime.Today.AddTicks(-user.FechaNacimiento.Ticks).Year - 1).ToString();
                    user.Fono1 = txt_nCasa.Text;
                    user.Fono2 = txt_nCelular.Text;

                    lblRespuesta.Text = user.imprimir() + "ok";
                    if (user.UpdateNuevo())
                    {
                        if (enfermera.Update())
                        {
                            lblRespuesta.Text = "Exito! Se ha actualizado";
                        }
                    }
                    else
                    {
                        lblRespuesta.Text = "No se actualizo";
                    }
                }
            }
        }
    }

}