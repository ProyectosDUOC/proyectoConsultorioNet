using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class EnfermeraColeccion
    {
        public static List<Enfermera> GenerarListado(List<Consultiorios.DALC.Enfermera> EnfermeraDALC)
        {
            List<Biblioteca.Clases.Enfermera> enfermeras = new List<Enfermera>();

            foreach (Consultiorios.DALC.Enfermera enfer in EnfermeraDALC)
            {
                Biblioteca.Clases.Enfermera enfermera = new Enfermera();

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
