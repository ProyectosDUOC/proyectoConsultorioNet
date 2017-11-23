using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio.ClasesListar
{
    public class FichaLListar
    {
        private int idFicha;

        public int IdFicha
        {
            get { return idFicha; }
            set { idFicha = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private String rut;

        public String Rut
        {
            get { return rut; }
            set { rut = value; }
        }
       
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String sector;

        public String Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        private String chequeo;

        public String Chequeo
        {
            get { return chequeo; }
            set { chequeo = value; }
        }

      

        


    }
}
