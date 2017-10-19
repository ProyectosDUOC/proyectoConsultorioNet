﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Region
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

        private Pais pais;

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public Region() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            Pais = null;
        }
    }
}
