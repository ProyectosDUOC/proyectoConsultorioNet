using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class JornadaLaboralColleccion
    {
        public List<JornadaLaboral> GenerarListado(List<capaDatos.Jornada_laboral> JornadaLaboralDALC)
        {
            List<capaNegocio.JornadaLaboral> jornadaLaborales = new List<JornadaLaboral>();

            foreach (capaDatos.Jornada_laboral jornada in JornadaLaboralDALC)
            {
                capaNegocio.JornadaLaboral jornadaLaboral = new JornadaLaboral();

                jornadaLaboral.Id = jornada.id_jornada_laboral;
                jornadaLaboral.Lunes = (int)jornada.lunes; 
                jornadaLaboral.Martes = (int)jornada.martes;
                jornadaLaboral.Miercoles = (int)jornada.miercoles;
                jornadaLaboral.Jueves = (int)jornada.jueves;
                jornadaLaboral.Viernes =(int) jornada.viernes;
                jornadaLaboral.IdSector = jornada.id_sector;
                jornadaLaboral.Glosa = jornada.glosa;

                jornadaLaborales.Add(jornadaLaboral);
            }
            return jornadaLaborales;
        }

        //Listado de todos los elementos

        public List<JornadaLaboral> ReadAll()
        {
            var jornadaLaborales = CommonBC.ModeloConsultorio.Jornada_laboral;
            return GenerarListado(jornadaLaborales.ToList());
        }
    }
}

