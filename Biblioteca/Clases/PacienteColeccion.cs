using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class PacienteColeccion
    {
        public List<Paciente> GenerarListado(List<Consultiorios.DALC.Paciente> PacienteDALC)
        {
            List<Biblioteca.Clases.Paciente> pacientes = new List<Paciente>();

            foreach (Consultiorios.DALC.Paciente pac in PacienteDALC)
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

        public List<Paciente> ReadAll()
        {
            var pacientes = CommonBC.ModeloConsultorio.Paciente;
            return GenerarListado(pacientes.ToList());
        }
    }
}
