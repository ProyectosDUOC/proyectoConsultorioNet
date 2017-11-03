using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class RegionColeccion
    {
        List<Biblioteca.ClasesExterior.Region> GenerarListado(List<Consultiorios.DALC.Region> regionesDALC)
        {
            List<Biblioteca.ClasesExterior.Region> regiones = new List<Region>();

            foreach (Consultiorios.DALC.Region reg in regionesDALC)
            {
                Region region = new Region();
                region.Id = reg.id_region;
                region.Nombre = reg.nom_region;
                region.IdPais = reg.id_pais;

                regiones.Add(region);
            }
            return regiones;
        }
    }
}
