using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class ConsultorioColeccion
    {
        public List<Consultorio> GenerarListado(List<Consultiorios.DALC.Consultorio> ConsultorioDALC)
        {
            List<Biblioteca.Clases.Consultorio> consultorios= new List<Consultorio>();

            foreach (Consultiorios.DALC.Consultorio consul in ConsultorioDALC)
            {
                Biblioteca.Clases.Consultorio consultorio = new Consultorio();

                consultorio.Id = consul.id_consultorio;
                consultorio.Rut = (int)consul.rut_consultorio;
                consultorio.Dv = Char.Parse(consul.dv);
                consultorio.Comuna.Id = consul.id_comuna;
                consultorio.Nombre = consul.nombre;
                
                consultorios.Add(consultorio);
            }
            return consultorios;
        }

        //Listado de todos los elementos

        public List<Consultorio> ReadAll()
        {
            var consultorios = CommonBC.ModeloConsultorio.Consultorio;
            return GenerarListado(consultorios.ToList());
        }
    }
}
