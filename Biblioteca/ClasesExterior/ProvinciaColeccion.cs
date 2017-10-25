using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class ProvinciaColeccion
    {
        public List<Biblioteca.ClasesExterior.Provincia> GenerarListado(List<Consultiorios.DALC.Provincia> provinciasDALC)
        {
            List<Provincia> provincias = new List<Provincia>();

            foreach (Consultiorios.DALC.Provincia prov in provinciasDALC)
            {
                Provincia provincia = new Provincia();
                provincia.Id = prov.id_provincia;
                provincia.Nombre = prov.nom_com;
                provincia.Region.Id = prov.id_region;

                provincias.Add(provincia);
            }
            return provincias;
        }
    }
}
