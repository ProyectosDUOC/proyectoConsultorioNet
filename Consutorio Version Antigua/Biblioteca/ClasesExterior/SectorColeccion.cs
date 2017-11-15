using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class SectorColeccion
    {
        List<Sector> GenerarListado(List<Consultiorios.DALC.Sector> sectoresDALC)
        {
            List<Sector> sectores = new List<Sector>();

            foreach (Consultiorios.DALC.Sector sectorDALC in sectoresDALC)
            {
                Sector sector = new Sector();
                sector.Id = sectorDALC.id_sector;
                sector.Nombre = sectorDALC.nombre;

                sectores.Add(sector);
            }
            return sectores;
        }
    }
}
