using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class TipoDesvinculado
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public TipoDesvinculado() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            glosa = String.Empty;
        }
    }
}
