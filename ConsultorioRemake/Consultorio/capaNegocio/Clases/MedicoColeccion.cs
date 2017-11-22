using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class MedicoColeccion
    {
        public static List<Medico> GenerarListado(List<capaDatos.Medico> MedicoDALC)
        {
            List<capaNegocio.Medico> medicos= new List<Medico>();

            foreach (capaDatos.Medico medic in MedicoDALC)
            {
                capaNegocio.Medico medico = new Medico();

                medico.Id = medic.id_Medico;
                medico.Rut = (int)medic.rut_medico;
                medico.IdUsuario = (int)medic.id_usuario;
                medico.IdEspecialidad = (int)medic.id_especialidad;
                medico.IdJornadaLaboral = (int)medic.id_jornada_laboral;
                
                medicos.Add(medico);
            }
            return medicos;
        }

        //Listado de todos los elementos

        public List<Medico> ReadAll()
        {
            var medicos = CommonBC.ModeloConsultorio.Medico;
            return GenerarListado(medicos.ToList());
        }
    }
    
}
