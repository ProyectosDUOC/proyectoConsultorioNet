using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class Enfermera: Usuario
    {
        private int idEnfermera { get; set; }

        public Enfermera() {}


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Enfermera {0}", idEnfermera);
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
