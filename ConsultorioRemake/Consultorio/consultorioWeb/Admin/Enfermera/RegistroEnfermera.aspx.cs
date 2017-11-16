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
        protected void Page_Load(object sender, EventArgs e)
        {
            bloqueo();
            if (!IsPostBack)
            {
                ddGenero.DataSource = capaNegocio.GeneroColeccion.ReadAll();
                ddNacionalidad.DataSource = capaNegocio.NacionalidadColeccion.ReadAll();
                ddComuna.DataSource = capaNegocio.ComunaColeccion.ReadAll();
                ddSector.DataSource = capaNegocio.SectorColeccion.ReadAll();

                ddGenero.DataBind();
                ddNacionalidad.DataBind();
                ddComuna.DataBind();
                ddSector.DataBind();
            }

        }

        protected void btn_Atras_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Admin/PanelEnfermera.aspx");
        }

        private void bloqueo()
        {
            txt_nFicha.Enabled = false;
            txt_pNombre.Enabled = false;
            txt_sNombre.Enabled = false;
            txt_apPaterno.Enabled = false;
            txt_apMaterno.Enabled = false;
            txt_Fecha.Enabled = false;
            ddGenero.Enabled = false;
            ddNacionalidad.Enabled = false;
            txt_Domicilio.Enabled = false;
            ddComuna.Enabled = false;
            ddSector.Enabled = false;
            txt_nCasa.Enabled = false;
            txt_nCelular.Enabled = false;
        }

        private void desbloqueo()
        {
            txt_nFicha.Enabled = true;
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
                if (enfermera.Read())
                {
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
                }
                else
                {
                    lblRespuesta.Text = "No entro enfermera ";
                }


            }
            else
            {
                lblRespuesta.Text = "No se encontro";
                //limpiar();
            }
        }
    }
}