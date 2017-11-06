using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class RegionColeccion
    {
        List<capaNegocio.Region> GenerarListado(List<capaDatos.Region> regionesDALC)
        {
            List<capaNegocio.Region> regiones = new List<Region>();

            foreach (capaDatos.Region reg in regionesDALC)
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
