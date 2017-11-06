using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class EspecialidadColeccion
    {
        public static List<Especialidad> GenerarListado(List<capaDatos.Especialidad> EspecialidadDALC)
        {
            List<capaNegocio.Especialidad> especialidades = new List<Especialidad>();

            foreach (capaDatos.Especialidad espe in EspecialidadDALC)
            {
                capaNegocio.Especialidad especialidad = new Especialidad();

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
