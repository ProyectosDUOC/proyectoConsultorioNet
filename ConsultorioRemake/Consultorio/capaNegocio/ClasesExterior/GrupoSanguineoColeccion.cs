using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class GrupoSanguineoColeccion
    {

        public static List<GrupoSanguineo> GenerarListado (List<capaDatos.Grupo_sanguineo> GrupoSanguienoDALC) 
        {
            List<capaNegocio.GrupoSanguineo> gruposSanguineos = new List<GrupoSanguineo>();

            foreach (capaDatos.Grupo_sanguineo grupS in GrupoSanguienoDALC)
            {
                capaNegocio.GrupoSanguineo gruposSanguineo = new GrupoSanguineo();

                gruposSanguineo.Id = grupS.id_grupo_sanguineo;
                gruposSanguineo.Nombre = grupS.nombre;

                gruposSanguineos.Add(gruposSanguineo);
            }
            return gruposSanguineos;
        }

        public List<GrupoSanguineo> ReadAll()
        {
            var grupoSanguineos = CommonBC.ModeloConsultorio.Grupo_sanguineo;
            return GenerarListado(grupoSanguineos.ToList());
        }

    }

}