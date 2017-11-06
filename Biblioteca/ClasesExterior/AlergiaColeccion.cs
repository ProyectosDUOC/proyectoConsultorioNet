using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class AlergiaColeccion
    {
        public static List<Alergia> GenerarListado(List<Consultiorios.DALC.Alergia> AlergiaDALC)
        {
            List<Biblioteca.ClasesExterior.Alergia> alergias= new List<Alergia>();

            foreach (Consultiorios.DALC. Alergia aler in AlergiaDALC)
            {
                Biblioteca.ClasesExterior.Alergia alergia = new Alergia();

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
