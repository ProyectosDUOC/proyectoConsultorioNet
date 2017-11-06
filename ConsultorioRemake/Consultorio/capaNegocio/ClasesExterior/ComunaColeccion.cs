using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class ComunaColeccion
    {
        public static List<Comuna> GenerarListado(List<capaDatos.Comuna> ComunaDALC)
        {
            List<capaNegocio.Comuna> comunas = new List<Comuna>();

            foreach (capaDatos.Comuna comun in ComunaDALC)
            {
                capaNegocio.Comuna comuna = new Comuna();

                //id = 0;
                //nombre = String.Empty;
                //provincia = null;

                comuna.Id = comun.id_comuna;
                comuna.Nombre = comun.nom_com;
                comuna.IdProvincia= comun.Provincia.id_provincia;

                comunas.Add(comuna);
            }
            return comunas;
        }

        //Listado de todos los elementos

        public List<Comuna> ReadAll()
        {
            var comunas = CommonBC.ModeloConsultorio.Comuna;
            return GenerarListado(comunas.ToList());
        }
    }
}
