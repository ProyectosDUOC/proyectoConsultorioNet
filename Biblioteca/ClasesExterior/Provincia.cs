using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Provincia
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

        private Region region;

        public Region Region
        {
            get { return region; }
            set { region = value; }
        }

        public Provincia() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            region = null;
        }
    }
}
