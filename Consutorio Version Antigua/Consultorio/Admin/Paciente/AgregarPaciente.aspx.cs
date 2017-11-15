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
                    usuario.Rut = int.Parse(txt_Rut.Text);
                    usuario.Dv =  Convert.ToChar(txt_dv.Text);
                    usuario.Pnombre = txt_pNombre.Text;
                    usuario.Snombre = txt_sNombre.Text;
                    usuario.Appaterno = txt_apPaterno.Text;
                    usuario.Apmaterno = txt_apMaterno.Text;


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