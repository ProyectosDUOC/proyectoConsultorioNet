using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class PaisColeccion
    {
        public List<capaNegocio.Pais> GenerarListado(List<capaDatos.Pais> paisesDALC)
        {
            List<Pais> paises = new List<Pais>();

            foreach (capaDatos.Pais paisDALC in paisesDALC)
            {
                Pais pais = new Pais();
                pais.Nombre = paisDALC.nom_pais;
                pais.Id = paisDALC.id_pais;

                paises.Add(pais);
            }
            return paises;
        }
    }
}
