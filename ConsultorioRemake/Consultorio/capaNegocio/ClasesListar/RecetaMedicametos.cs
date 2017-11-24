using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio.ClasesListar
{
    public class RecetaMedicametos
    {
         private int idReceta;

        public int IdReceta
        {
            get { return idReceta; }
            set { idReceta = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private int hora;

        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private int dia;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public RecetaMedicametos() {
            init();        
        }

        private void init() {         
            IdReceta=0;
            Fecha = DateTime.Now;
            Cant = 0;
            Hora = 0;
            Dia = 0;
            Glosa = "";
            Nombre = "";
        }
    }
}
