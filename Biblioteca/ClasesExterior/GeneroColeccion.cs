using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class GeneroColeccion
    {
        public List<Genero> GenerarListado(List<Consultiorios.DALC.Genero> GeneroDALC)
        {
            List<Biblioteca.ClasesExterior.Genero> generos = new List<Genero>();

            foreach (Consultiorios.DALC.Genero gen in GeneroDALC)
            {
                Biblioteca.ClasesExterior.Genero genero = new Genero();

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
