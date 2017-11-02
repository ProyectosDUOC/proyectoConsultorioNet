using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Clases;

namespace Consultorio.Admin.Paciente
{
    public partial class AgregarPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }
        protected void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Biblioteca.Clases.Paciente paciente = new Biblioteca.Clases.Paciente();
                Biblioteca.Usuario usuario = new Biblioteca.Usuario();
                paciente.Id = int.Parse(txt_nFicha.Text);
                if (!paciente.Read())
                {
                    paciente.IdUsuario. = int.Parse(txt_Rut.Text);
                    paciente.Usuario.Dv = Char.Parse(txt_dv.Text);
                    paciente.Usuario.Pnombre = txt_pNombre.Text;
                    paciente.Usuario.Snombre = txt_sNombre.Text;
                    paciente.Usuario.Appaterno = txt_apPaterno.Text;
                    paciente.Usuario.Apmaterno = txt_apMaterno.Text;
                    paciente.Usuario.Genero.Id = ddlGenero.SelectedIndex;
                    paciente.Usuario.FechaNacimiento = DateTime.Parse(txt_Fecha.Text);
                    paciente.Usuario.Nacionalidad.Id = ddNacionalidad.SelectedIndex;
                    paciente.Usuario.Direccion = txt_Domicilio.Text;
                    paciente.Usuario.Comuna.Id = ddComuna.SelectedIndex;
                    paciente.Sector.Id = ddSector.SelectedIndex;
                    paciente.GrupoSanguineo.Id = ddGrupoS.SelectedIndex;
                    paciente.Rh.Id = ddlRh.SelectedIndex;

                    if (paciente.Create())
                    {
                        lblRespuesta.Text = "Creado";
                    }
                    else
                    {
                        lblRespuesta.Text = "no Creado";
                    }
                }
                else {
                    lblRespuesta.Text = "Paciente ya registrado";
                }
                
                

            }
            catch (Exception ex)
            {

                lblRespuesta.Text = "Error en crear paciente";
            }
           // Response.Redirect("/Admin/PanelPaciente.aspx");
        }

     
    }
}