using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class EspecialidadColeccion
    {
        public static List<Especialidad> GenerarListado(List<Consultiorios.DALC.Especialidad> EspecialidadDALC)
        {
            List<Biblioteca.ClasesExterior.Especialidad> especialidades = new List<Especialidad>();

            foreach (Consultiorios.DALC.Especialidad espe in EspecialidadDALC)
            {
                Biblioteca.ClasesExterior.Especialidad especialidad = new Especialidad();

                especialidad.Id = espe.id_especialidad;
                especialidad.Nombre = espe.nom_especialidad;

                especialidades.Add(especialidad);
            }
            return especialidades;
        }

        //Listado de todos los elementos

        public List<Especialidad> ReadAll()
        {
            var especialidades = CommonBC.ModeloConsultorio.Especialidad;
            return GenerarListado(especialidades.ToList());
        }
    }
}
