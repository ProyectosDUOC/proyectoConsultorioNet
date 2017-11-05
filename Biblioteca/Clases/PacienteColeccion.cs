using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Consultiorios.DALC;

namespace Biblioteca.Clases
{
    public class PacienteColeccion
    {
        public static List<Paciente> GenerarListado()
        {

            List<Biblioteca.Clases.Paciente> pacientes = new List<Paciente>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var paci = ee.Paciente; 

            foreach (Consultiorios.DALC.Paciente pac in paci.ToList())
            {
                Biblioteca.Clases.Paciente paciente = new Paciente();
               

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

       
    }
}
