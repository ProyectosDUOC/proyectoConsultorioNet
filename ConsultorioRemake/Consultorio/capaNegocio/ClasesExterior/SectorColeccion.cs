using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class SectorColeccion
    {
     public static List<Sector> GenerarListado(List<capaDatos.Sector> sectoresDALC)
        {
            List<Sector> sectores = new List<Sector>();

            foreach (capaDatos.Sector sectorDALC in sectoresDALC)
            {
                Sector sector = new Sector();
                sector.Id = sectorDALC.id_sector;
                sector.Nombre = sectorDALC.nombre;

                sectores.Add(sector);
            }
            return sectores;
        }
     public static List<Sector> ReadAll()
     {
         var sectores = CommonBC.ModeloConsultorio.Sector;
         return GenerarListado(sectores.ToList());
     }
    }
}
