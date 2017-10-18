using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class ControlAcceso
    {
        public int id {get; set; }
        public String username { get; set; }
        public String pass { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private int activo;

        public int Activo
        {
            get { return Activo; }
            set { Activo = value; }
        }

        public ControlAcceso() {
            Init();
        }

        private void Init() {
            id = 0;
            username = String.Empty ;
            pass = String.Empty;
            tipoUsuario = null;
            usuario = null;
            Activo = 0;
        }

     /*   public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id ControlAcceso: {0} usuario : {1}  pass : {2} ", id, usuario, pass);
            return sb.ToString();
        }*/

    }
}
