using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class GrupoSanguineoColeccion
    {
        public List<GrupoSanguineo> GenerarListado (List<Consultiorios.DALC.Grupo_sanguineo> GrupoSanguienoDALC) 
        {
            List<Biblioteca.ClasesExterior.GrupoSanguineo> gruposSanguineos = new List<GrupoSanguineo>();

            foreach (Consultiorios.DALC.Grupo_sanguineo grupS in GrupoSanguienoDALC)
            {
                Biblioteca.ClasesExterior.GrupoSanguineo gruposSanguineo = new GrupoSanguineo();

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