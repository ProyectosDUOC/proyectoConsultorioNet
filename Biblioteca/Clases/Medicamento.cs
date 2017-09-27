using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class Medicamento
    {
        public int id { get; set; }
        public String nombre { get; set; }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // sb.AppendFormat("Medico: rut Medico : {0}-{1} /n Especialidad : {2}", rutMedico, dvMedico, especialidad);
            sb.AppendFormat("id medicamento: {0} nombre medicamento : {1} ", id, nombre);
            return sb.ToString();
        }
    }
}
