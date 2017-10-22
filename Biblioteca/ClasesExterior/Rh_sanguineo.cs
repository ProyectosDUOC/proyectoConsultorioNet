    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Rh_sanguineo
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

        public Rh_sanguineo() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
        }
    }
}
