using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class GrupoSanguineoColeccion
    {
        public static List<GrupoSanguineo> GenerarListado (List<Consultiorios.DALC.Grupo_sanguineo> GrupoSanguienoDAlC) 
        {
            List<Biblioteca.ClasesExterior.GrupoSanguineo> gruposSanguineos = new List<GrupoSanguineo>();

            foreach (Consultiorios.DALC.Grupo_sanguineo grupS in GrupoSanguienoDAlC)
            {
                Biblioteca.ClasesExterior.GrupoSanguineo gruposSanguineo = new GrupoSanguineo();

                gruposSanguineo.Id = grupS.id_grupo_sanguineo;
                gruposSanguineo.Nombre = grupS.nombre;

                gruposSanguineos.Add(gruposSanguineo);
            }
            return gruposSanguineos;
        }
    }

}
