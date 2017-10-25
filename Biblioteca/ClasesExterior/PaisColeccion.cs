using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class PaisColeccion
    {
        public List<Biblioteca.ClasesExterior.Pais> GenerarListado(List<Consultiorios.DALC.Pais> paisesDALC)
        {
            List<Pais> paises = new List<Pais>();

            foreach (Consultiorios.DALC.Pais paisDALC in paisesDALC)
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
