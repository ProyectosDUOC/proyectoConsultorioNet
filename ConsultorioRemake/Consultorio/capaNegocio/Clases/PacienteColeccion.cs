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


                paciente.Id = (int)pac.id_paciente;
                paciente.IdUsuario = (int)pac.id_usuario;
                paciente.IdGrupoSanguineo = (int)pac.id_grupo_sanguineo;
                paciente.IdRh = (int)pac.id_rh;
                paciente.IdSector = (int)pac.id_sector;

                pacientes.Add(paciente);
            }
            return pacientes;
        }

                
    }
}
