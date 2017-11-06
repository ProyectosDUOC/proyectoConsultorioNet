using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class EnfermeraColeccion
    {
        public static List<Enfermera> GenerarListado(List<capaDatos.Enfermera> EnfermeraDALC)
        {
            List<capaNegocio.Enfermera> enfermeras = new List<Enfermera>();

            foreach (capaDatos.Enfermera enfer in EnfermeraDALC)
            {
                capaNegocio.Enfermera enfermera = new Enfermera();

                enfermera.Id = enfer.id_enfermera;               
                enfermera.IdUsuario = enfer.id_usuario;
                enfermera.IdJornadaLaboral= enfer.id_jornada_laboral;

                enfermeras.Add(enfermera);
            }
            return enfermeras;
        }

        //Listado de todos los elementos

        public List<Enfermera> ReadAll()
        {
            var enfermeras = CommonBC.ModeloConsultorio.Enfermera;
            return GenerarListado(enfermeras.ToList());
        }
    }
}
