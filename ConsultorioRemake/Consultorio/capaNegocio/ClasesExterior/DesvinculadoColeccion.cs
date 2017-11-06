using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class DesvinculadoColeccion
    {
        public static List<Desvinculado> GenerarListado(List<capaDatos.Desvinculado>  DesvinculadoDALC)
        {
            List<capaNegocio.Desvinculado> desvinculados = new List<Desvinculado>();

            foreach (capaDatos.Desvinculado desvin in DesvinculadoDALC)
            {
                capaNegocio.Desvinculado desvinculado = new Desvinculado();

                desvinculado.Id = desvin.id_desvinculado;
                desvinculado.IdUsuario = desvin.id_usuario;
                desvinculado.Fecha = (DateTime)desvin.fecha;
                desvinculado.IdTipoDesvinculado = desvin.Tipo_Desvinculado.id_tipo_desvin;
                desvinculado.Glosa = desvin.glosa; 

                desvinculados.Add(desvinculado);
            }
            return desvinculados;
        }

        //Listado de todos los elementos

        public List<Desvinculado> ReadAll()
        {
            var desvinculados = CommonBC.ModeloConsultorio.Desvinculado;
            return GenerarListado(desvinculados.ToList());
        }
    }
}
