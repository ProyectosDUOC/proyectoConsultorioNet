using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class SecretariaColeccion
    {
        public static List<Secretaria> GenerarListado(List<capaDatos.Secretaria> SecretariaDALC)
        {
            List<capaNegocio.Secretaria> secretarias= new List<Secretaria>();

            foreach (capaDatos.Secretaria secre in SecretariaDALC)
            {
                capaNegocio.Secretaria secretaria= new Secretaria();

                secretaria.Id = secre.id_secretaria;
                secretaria.IdUsuario = secre.id_usuario;
                secretaria.IdJornadaLaboral = secre.id_jornada_laboral;
                
                secretarias.Add(secretaria);
            }
            return secretarias;
        }

        //Listado de todos los elementos

        public List<Secretaria> ReadAll()
        {
            var secretarias = CommonBC.ModeloConsultorio.Secretaria;
            return GenerarListado(secretarias.ToList());
        }
    
    }
}
