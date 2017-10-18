using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Comuna
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

        private Provincia provincia;

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public Comuna() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            provincia = null;
        }
    }
}
