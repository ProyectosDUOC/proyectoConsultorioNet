using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Medico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        private JornadaLaboral jornadaLaboral;

        public JornadaLaboral JornadaLaboral
        {
            get { return jornadaLaboral; }
            set { jornadaLaboral = value; }
        }



        private void Init() {
            id = 0;
            rut = 0;
            dv = '0';
            usuario = null;
            especialidad = null;
            jornadaLaboral = null;
        }
    }
}
