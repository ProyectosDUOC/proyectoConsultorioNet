using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class NacionalidadColeccion
    {
        public List<Nacionalidad> GenerarListado(List<Consultiorios.DALC.Nacionalidad> nacionalidadesDALC)
        {
            List<Biblioteca.ClasesExterior.Nacionalidad> nacionalidades = new List<Nacionalidad>();

            foreach (Consultiorios.DALC.Nacionalidad nac in nacionalidadesDALC)
            {
                Nacionalidad nacionalidad = new Nacionalidad();
                nacionalidad.Id = nac.id_nacionalidad;
                nacionalidad.Nombre = nac.nom_nacio;

                nacionalidades.Add(nacionalidad);
            }
            return nacionalidades;
        }
    }
}
