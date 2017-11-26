using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using capaNegocio;

namespace capaServiciosWeb
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
                return usuario.Rut+"-"+usuario.Dv;

	        }
	        catch (Exception ex)
	        {
		
		       return "Error"+ex.Message;
	        }           

        }

        public string nombrePacienteIdFicha(int id)
        {
            String nombre="";
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
                return usuario.Pnombre + " " +usuario.Appaterno ;

            }
            catch (Exception ex)
            {

                return "Error" + ex.Message;
            }           
        
        }

        public string cantidadMedicamento(int idFicha, int idMedicamento)
        {
            String cantidad="0";
            try
            {
                List<capaNegocio.Clases.RecetaMedica> lista = new List<capaNegocio.Clases.RecetaMedica>();
                lista = capaNegocio.Clases.RecetaListar.generarReceta();
                foreach (capaNegocio.Clases.RecetaMedica xx in lista.ToList())
                {
                    if (xx.IdFicha== idFicha)
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


/*

        public PacienteFicha buscarPaciente(int id)
        {
            try
            {
                Paciente paciente = new Paciente();
                paciente.Id = id;
                paciente.Read();
                Usuario usuario = new Usuario();
                usuario.Id = paciente.IdUsuario;
                usuario.Read();

                PacienteFicha pacienteNuevo = new PacienteFicha();
                pacienteNuevo.IdPaciente = id.ToString();
                pacienteNuevo.IdUsuario = usuario.Id.ToString();
                pacienteNuevo.Rut = usuario.Rut + "-" + usuario.Dv;
                pacienteNuevo.Nombres = usuario.Pnombre + " " + usuario.Snombre ;
                pacienteNuevo.Apellidos = usuario.Appaterno + " " + usuario.Apmaterno;
                string edad = (DateTime.Today.AddTicks(-usuario.FechaNacimiento.Ticks).Year - 1).ToString();

                pacienteNuevo.Edad = Convert.ToInt32(edad);
                pacienteNuevo.Direccion = usuario.Direccion;
                pacienteNuevo.ComunaCodigo = 1;
                pacienteNuevo.Correo = "contacto@consultorio";
                pacienteNuevo.Contacto = Convert.ToInt32(usuario.Fono1);
                Genero genero = new Genero();
                genero.Id = usuario.IdGenero;
                genero.Read();
                pacienteNuevo.Genero = genero.Nombre;
                return pacienteNuevo;
            }
            catch (Exception)
            {

                return null;
            }           
            
        }*/
    }
}
