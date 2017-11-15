using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio
{
    public class PacienteColeccion
    {
        public static List<Paciente> GenerarListado()
        {

            List<capaNegocio.Paciente> pacientes = new List<Paciente>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var paci = ee.Paciente; 

            foreach (capaDatos.Paciente pac in paci.ToList())
            {
                capaNegocio.Paciente paciente = new Paciente();
               

                paciente.Id = pac.id_paciente;
                paciente.IdUsuario = pac.id_usuario;
                paciente.IdGrupoSanguineo = pac.id_grupo_sanguineo;
                paciente.IdRh = pac.id_rh;
                paciente.IdSector = pac.id_sector;

                pacientes.Add(paciente);
            }
            return pacientes;
        }

        //Listado de todos los elementos


        public static List<Object> GenerarListadoAll()
        {
            //Creo un objeto X
            List<Object> listaPacientes = new List<object>();

            //Ingreso a la base de datos
            ConsultoriosEntities ee = new ConsultoriosEntities();

            //Genero Lista entrelazadas


            //llamo todas las clases que se iran a mostrar

            List<capaNegocio.Paciente> pacientes = new List<Paciente>();
            List<capaNegocio.Usuario> usuarios = new List<Usuario>();

            

            var paci = ee.Paciente;
            var usua = ee.Usuario;

            foreach (capaDatos.Paciente pac in paci.ToList())
            {
                capaNegocio.Paciente paciente = new Paciente();

                Object obj = new Object();

                

                paciente.Id = pac.id_paciente;
                paciente.IdUsuario = pac.id_usuario;
                paciente.IdGrupoSanguineo = pac.id_grupo_sanguineo;
                paciente.IdRh = pac.id_rh;
                paciente.IdSector = pac.id_sector;

                pacientes.Add(paciente);
            }
            return listaPacientes;
        }
    }
}
