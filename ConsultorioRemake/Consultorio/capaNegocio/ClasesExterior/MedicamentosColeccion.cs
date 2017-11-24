using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class MedicamentosColeccion
    {
        public static List<Medicamentos> GenerarListado(List<capaDatos.Medicamentos> medicamentosDALC)
        {
            List<capaNegocio.Medicamentos> medicamentos = new List<Medicamentos>();

            foreach (capaDatos.Medicamentos med in medicamentosDALC)
            {
                capaNegocio.Medicamentos medicamento = new Medicamentos();
                
                medicamento.Id = med.id_medicamentos;
                medicamento.Nombre = med.nombre_producto;
                medicamento.PrincipioActivo = med.principio_activo;
                medicamento.ProductoReferencia = med.producto_referencia;
                medicamento.Glosa = med.glosa;

                medicamentos.Add(medicamento);
            }
            return medicamentos;
        }

        public static List<Medicamentos> ReadAll()
        {
            var nacionalidades = CommonBC.ModeloConsultorio.Medicamentos;
            return GenerarListado(nacionalidades.ToList());
        }
    }
}
