using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class JornadaLaboral
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int lunes;

        public int Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }
        private int martes;

        public int Martes
        {
            get { return martes; }
            set { martes = value; }
        }
        private int miercoles;

        public int Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }
        private int jueves;

        public int Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }
        private int viernes;

        public int Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }
        private int sabado;

        public int Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }
        private int domingo;

        public int Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }
        private Sector sector;

        public Sector Sector
        {
            get { return sector; }
            set { sector = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public JornadaLaboral() {
            Init();
        }

        private void Init() {
            id = 0;
            lunes = 0;
            martes = 0;
            miercoles = 0;
            jueves = 0;
            viernes = 0;
            sabado = 0;
            domingo = 0;
            sector = null;
            glosa = String.Empty;
        }

    }
}
