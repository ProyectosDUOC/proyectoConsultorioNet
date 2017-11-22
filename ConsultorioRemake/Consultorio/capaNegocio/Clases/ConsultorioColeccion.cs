using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class ConsultorioColeccion
    {
        public static List<Consultorio> GenerarListado(List<capaDatos.Consultorio> ConsultorioDALC)
        {
            List<capaNegocio.Consultorio> consultorios= new List<Consultorio>();

            foreach (capaDatos.Consultorio consul in ConsultorioDALC)
            {
                capaNegocio.Consultorio consultorio = new Consultorio();

                consultorio.Id = consul.id_consultorio;
                consultorio.Rut = (int)consul.rut_consultorio;
                consultorio.Dv = Char.Parse(consul.dv);
                consultorio.IdComuna = (int)consul.id_comuna;
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
