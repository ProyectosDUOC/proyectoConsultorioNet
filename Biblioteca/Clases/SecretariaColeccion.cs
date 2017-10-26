using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class SecretariaColeccion
    {
        public List<Secretaria> GenerarListado(List<Consultiorios.DALC.Secretaria> SecretariaDALC)
        {
            List<Biblioteca.Clases.Secretaria> secretarias= new List<Secretaria>();

            foreach (Consultiorios.DALC.Secretaria secre in SecretariaDALC)
            {
                Biblioteca.Clases.Secretaria secretaria= new Secretaria();

                secretaria.Id = secre.id_secretaria;
                secretaria.Usuario.Id = secre.id_usuario;
                secretaria.JornadaLaboral.Id = secre.id_jornada_laboral;
                
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
