using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Rh_sanguineoColeccion
    {
       public static List<capaNegocio.Rh_sanguineo> GenerarListado(List<capaDatos.Rh_sanguineo> rhsDALC)
        {
            List<Rh_sanguineo> rhsLista = new List<Rh_sanguineo>();

            foreach (capaDatos.Rh_sanguineo rh_DALC in rhsDALC)
            {
                Rh_sanguineo rh_sanguineo = new Rh_sanguineo();
                rh_sanguineo.Id = rh_DALC.id_rh;
                rh_sanguineo.Nombre = rh_DALC.nombre;

                rhsLista.Add(rh_sanguineo);
            }
            return rhsLista;
        }

       public static List<Rh_sanguineo> ReadAll()
       {
           var rhs = CommonBC.ModeloConsultorio.Rh_sanguineo;
           return GenerarListado(rhs.ToList());
       }
    }
}
