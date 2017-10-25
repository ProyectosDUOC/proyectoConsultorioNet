using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class MedicoColeccion
    {
        public List<Medico> GenerarListado(List<Consultiorios.DALC.Medico> MedicoDALC)
        {
            List<Biblioteca.Clases.Medico> medicos= new List<Medico>();

            foreach (Consultiorios.DALC.Medico medic in MedicoDALC)
            {
                Biblioteca.Clases.Medico medico = new Medico();

                medico.Id = medic.id_Medico;
                medico.Rut = medic.rut_medico;
                medico.Usuario.Id = medic.id_usuario;
                medico.Especialidad.Id = medic.id_especialidad;
                medico.JornadaLaboral.Id = medic.id_jornada_laboral;
                
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
