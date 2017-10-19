using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Paciente
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
        private GrupoSanguineo grupoSanguineo;

        public GrupoSanguineo GrupoSanguineo
        {
            get { return grupoSanguineo; }
            set { grupoSanguineo = value; }
        }
        private Rh_sanguineo rh;

        public Rh_sanguineo Rh
        {
            get { return rh; }
            set { rh = value; }
        }
        private Sector sector;

        public Sector Sector
        {
            get { return sector; }
            set { sector = value; }
        }
              
        public Paciente() {
            Init();
        }
        private void Init() {
            id = 0;
            usuario = null;
            grupoSanguineo = null;
            rh = null;
            sector = null;
        }
    }
}
