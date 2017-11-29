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

namespace WebServicioConsultorio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    public class Service1 : IService1
    {
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
