using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Rh_sanguineoColeccion
    {
        List<Biblioteca.ClasesExterior.Rh_sanguineo> GenerarListado(List<Consultiorios.DALC.Rh_sanguineo> rhsDALC)
        {
            List<Rh_sanguineo> rhsLista = new List<Rh_sanguineo>();

            foreach (Consultiorios.DALC.Rh_sanguineo rh_DALC in rhsDALC)
            {
                Rh_sanguineo rh_sanguineo = new Rh_sanguineo();
                rh_sanguineo.Id = rh_DALC.id_rh;
                rh_sanguineo.Nombre = rh_DALC.nombre;

                rhsLista.Add(rh_sanguineo);
            }
            return rhsLista;
        }
    }
}
