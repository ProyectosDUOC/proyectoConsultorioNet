using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Enfermera
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private JornadaLaboral jornadaLaboral;

        public JornadaLaboral JornadaLaboral
        {
            get { return jornadaLaboral; }
            set { jornadaLaboral = value; }
        }

        public Enfermera(){
            Init();
        }

        private void Init(){
            id = 0;
            usuario = null;
            jornadaLaboral = null;
        }

    }
}
