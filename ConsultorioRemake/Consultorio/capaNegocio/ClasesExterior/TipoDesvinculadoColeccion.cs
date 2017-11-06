using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class TipoDesvinculadoColeccion
    {
        List<TipoDesvinculado> GenerarListado(List<capaDatos.Tipo_Desvinculado> desvinculadosDALC)
        {
            List<TipoDesvinculado> tipo_desvinculados = new List<TipoDesvinculado>();

            foreach (capaDatos.Tipo_Desvinculado desvDALC in desvinculadosDALC)
            {
                TipoDesvinculado desv = new TipoDesvinculado();
                desv.Id = desvDALC.id_tipo_desvin;
                desv.Nombre = desvDALC.nombre;
                desv.Glosa = desvDALC.glosa;

                tipo_desvinculados.Add(desv);
            }
            return tipo_desvinculados;
        }
    }
}
