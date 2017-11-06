using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class AlergiaColeccion
    {
        public static List<Alergia> GenerarListado(List<capaDatos.Alergia> AlergiaDALC)
        {
            List<capaNegocio.Alergia> alergias= new List<Alergia>();

            foreach (capaDatos. Alergia aler in AlergiaDALC)
            {
                capaNegocio.Alergia alergia = new Alergia();

                alergia.Id = aler.id_alergia;
                alergia.Nombre = aler.nombre;

                alergias.Add(alergia);
            }
            return alergias;
        }

        //Listado de todos los elementos

        public List<Alergia> ReadAll()
        {
            var alergias = CommonBC.ModeloConsultorio.Alergia;
            return GenerarListado(alergias.ToList());
        }
    
    }
}
