using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class ControlAcceso
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String pass;

        public String e
        {
            get { return pass; }
            set { pass = value; }
        }
        private TipoUsuario tipoUsuario;

        public TipoUsuario TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

      
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
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
            activo = 0;
        }

     /*   public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id ControlAcceso: {0} usuario : {1}  pass : {2} ", id, usuario, pass);
            return sb.ToString();
        }*/

    }
}
