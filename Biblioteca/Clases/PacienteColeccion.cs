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
                paciente.Usuario.Id = pac.id_usuario;
                paciente.GrupoSanguineo.Id = pac.id_grupo_sanguineo;
                paciente.Rh.Id = pac.id_rh;
                paciente.Sector.Id = pac.id_sector;

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
