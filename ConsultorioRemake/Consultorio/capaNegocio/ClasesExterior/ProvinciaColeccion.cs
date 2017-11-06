using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class ProvinciaColeccion
    {
        public List<capaNegocio.Provincia> GenerarListado(List<capaDatos.Provincia> provinciasDALC)
        {
            List<Provincia> provincias = new List<Provincia>();

            foreach (capaDatos.Provincia prov in provinciasDALC)
            {
                Provincia provincia = new Provincia();
                provincia.Id = prov.id_provincia;
                provincia.Nombre = prov.nom_com;
                provincia.IdRegion = prov.id_region;

                provincias.Add(provincia);
            }
            return provincias;
        }
    }
}
