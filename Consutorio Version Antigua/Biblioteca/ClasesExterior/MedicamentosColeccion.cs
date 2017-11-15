using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class MedicamentosColeccion
    {
        public List<Medicamentos> GenerarListado(List<Consultiorios.DALC.Medicamentos> medicamentosDALC)
        {
            List<Biblioteca.ClasesExterior.Medicamentos> medicamentos = new List<Medicamentos>();

            foreach (Consultiorios.DALC.Medicamentos med in medicamentosDALC)
            {
                Biblioteca.ClasesExterior.Medicamentos medicamento = new Medicamentos();
                
                medicamento.Id = med.id_medicamentos;
                medicamento.Nombre = med.nombre_producto;
                medicamento.PrincipioActivo = med.principio_activo;
                medicamento.ProductoReferencia = med.producto_referencia;
                medicamento.Glosa = med.glosa;

                medicamentos.Add(medicamento);
            }
            return medicamentos;
        }
    }
}
