using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class GeneroColeccion
    {
        public static List<Genero> GenerarListado(List<capaDatos.Genero> GeneroDALC)
        {
            List<capaNegocio.Genero> generos = new List<Genero>();

            foreach (capaDatos.Genero gen in GeneroDALC)
            {
                capaNegocio.Genero genero = new Genero();

                //id = 0;
                //nombre = String.Empty;

                genero.Id = gen.id_genero;
                genero.Nombre = gen.nom_genero;

                generos.Add(genero);
            }
            return generos;
        }

        //Listado de todos los elementos

        public List<Genero> ReadAll()
        {
            var generos = CommonBC.ModeloConsultorio.Genero;
            return GenerarListado(generos.ToList());
        }
    }
}
