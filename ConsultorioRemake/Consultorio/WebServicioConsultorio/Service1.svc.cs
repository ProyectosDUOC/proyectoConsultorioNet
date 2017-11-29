using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using capaNegocio.Clases;
using capaNegocio.ClasesListar;
using capaNegocio.Control;
using capaNegocio;

namespace WebServicioConsultorio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Service1 : IService1
    {
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

        public string glosaRecetaMedica(int idFicha, int idMedicamento)
        {
            string glosa = ""; //glosa es el total ...
            try
            {
                RecetaMedica recetaM = new RecetaMedica();
                recetaM.IdFicha = idFicha;
                recetaM.ReadFicha();
                return recetaM.Glosa;
            }
            catch (Exception)
            {
                return "no existe";   
            }

        }

        public string buscarRutDoctor(int idFichaPaciente) //Medico
        {

            string glosa = " ";
            try
            {
                capaNegocio.FichaPaciente fichaPaciente = new capaNegocio.FichaPaciente();
                fichaPaciente.Id_ficha_paciente = idFichaPaciente;
                fichaPaciente.Read();
                capaNegocio.Medico medico = new capaNegocio.Medico();
                capaNegocio.Usuario usuario = new capaNegocio.Usuario();

                medico.Id = fichaPaciente.IdMedico;
                medico.Read();

                usuario.Id = medico.IdUsuario;
                usuario.Read();

                //return medico.Rut;
                glosa = medico.Rut.ToString() ;
                return glosa;

            }
            catch (Exception)
            {
                
                return "no existe";
            }
        }

        public string buscarNombreDoctor(int idFichaPaciente)
        {
            string glosa = "";

            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Read();
            capaNegocio.Medico medico = new capaNegocio.Medico();
            capaNegocio.Usuario usuario = new capaNegocio.Usuario();

            medico.Id = ficha.IdMedico;
            usuario.Read();

            glosa = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            return glosa;
        }

        public string buscarRutPaciente(int idFichaPaciente) 
        {
            string glosa = "";

            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Read();
            capaNegocio.Paciente paciente = new capaNegocio.Paciente();
            capaNegocio.Usuario usuario = new capaNegocio.Usuario();

            paciente.Id = ficha.IdPaciente;
            paciente.Read();

            glosa = usuario.Rut.ToString();
            return glosa;
        }

        public string buscarNombrePaciente(int idFichaPaciente) 
        {
            string glosa = "";

            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Read();
            capaNegocio.Paciente paciente = new capaNegocio.Paciente();
            capaNegocio.Usuario usuario = new capaNegocio.Usuario();

            paciente.Id = ficha.IdPaciente;
            paciente.Read();

            glosa = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            return glosa;
        }

    }
}
