using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class Secretaria: Usuario
    {
        public int idSecretaria { get; set; }

          public Secretaria() {}


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Secretaria {1}", idSecretaria);
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
