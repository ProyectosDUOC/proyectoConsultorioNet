using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class ControlAcceso
    {
        public int id {get; set; }
        public String usuario { get; set; }
        public String pass { get; set; }
        public String tipoUsuario { get; set; }

        public ControlAcceso() {
            Init();
        }

        private void Init() {
            id = 0;
            usuario = String.Empty;
            pass = String.Empty;
            tipoUsuario = String.Empty;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id ControlAcceso: {0} usuario : {1}  pass : {2} ", id, usuario, pass);
            return sb.ToString();
        }

    }
}
