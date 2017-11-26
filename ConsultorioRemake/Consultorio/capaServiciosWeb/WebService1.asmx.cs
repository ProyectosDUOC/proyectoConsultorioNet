using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using capaNegocio;

namespace capaServiciosWeb
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://localhost/Consultorio")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        [WebMethod]
        public string rutPacienteId(int id)
        {
            try
            {
                Paciente paciente = new Paciente();
                paciente.Id = id;
                paciente.Read();

                Usuario usuario = new Usuario();
                usuario.Id = paciente.IdUsuario;
                usuario.Read();
                return usuario.Rut + "-" + usuario.Dv;

            }
            catch (Exception ex)
            {

                return "Error" + ex.Message;
            }

        }

        [WebMethod]
        public string nombrePacienteIdFicha(int id)
        {
            String nombre = "";
            try
            {
                capaNegocio.FichaPaciente ficha = new FichaPaciente();
                ficha.Id_ficha_paciente = id;
                ficha.Read();
                capaNegocio.Paciente paciente = new Paciente();
                capaNegocio.Usuario usuario = new Usuario();

                paciente.Id = ficha.IdPaciente;
                paciente.Read();
                usuario.Id = paciente.IdUsuario;
                usuario.Read();

                nombre = usuario.Pnombre + " " + usuario.Appaterno;
                return nombre;
            }
            catch (Exception)
            {

                return nombre;
            }
        }

        [WebMethod]
        public string rutMedicoIdFicha(int id)
        {
            try
            {
                Medico medico = new Medico();
                medico.Id = id;
                medico.Read();

                Usuario usuario = new Usuario();
                usuario.Id = medico.IdUsuario;
                usuario.Read();
                return usuario.Rut + "-" + usuario.Dv;

            }
            catch (Exception ex)
            {

                return "Error" + ex.Message;
            }
        }

        [WebMethod]
        public string nombreMedicoId(int id)
        {
            try
            {
                Medico medico = new Medico();
                medico.Id = id;
                medico.Read();

                Usuario usuario = new Usuario();
                usuario.Id = medico.IdUsuario;
                usuario.Read();
                return usuario.Pnombre + " " + usuario.Appaterno;

            }
            catch (Exception ex)
            {

                return "Error" + ex.Message;
            }

        }

        [WebMethod]
        public string cantidadMedicamento(int idFicha, int idMedicamento)
        {
            String cantidad = "0";
            try
            {
                List<capaNegocio.Clases.RecetaMedica> lista = new List<capaNegocio.Clases.RecetaMedica>();
                lista = capaNegocio.Clases.RecetaListar.generarReceta();
                foreach (capaNegocio.Clases.RecetaMedica xx in lista.ToList())
                {
                    if (xx.IdFicha == idFicha)
                    {
                        if (xx.IdMedicamento == idMedicamento)
                        {
                            cantidad = xx.Glosa;
                            return cantidad;
                        }
                    }
                }
                return cantidad;

            }
            catch (Exception ex)
            {
                return "Error" + ex.Message;
            }
        }

    }
}
