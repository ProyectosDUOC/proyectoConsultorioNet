using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class NacionalidadColeccion
    {
        public List<Nacionalidad> GenerarListado(List<capaDatos.Nacionalidad> nacionalidadesDALC)
        {
            List<capaNegocio.Nacionalidad> nacionalidades = new List<Nacionalidad>();

            foreach (capaDatos.Nacionalidad nac in nacionalidadesDALC)
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
