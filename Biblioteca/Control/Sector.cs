using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Control
{
    public class Sector
    {
        public int id { get; set; }
        public String nombre { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id Sector: {0} nombre: {1}", id, nombre);
            return sb.ToString();
        }
    }
}
