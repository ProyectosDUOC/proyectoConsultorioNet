using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class EnfermeraListar
    {
        public int Id { get; set; }
        public int Rut { get; set; }
        public char Dv { get; set; }
        public String Foto { get; set; }
        public String Pnombre { get; set; }
        public String Snombre { get; set; }
        public String Appaterno { get; set; }
        public String Apmaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Direccion { get; set; }
        public String Fono1 { get; set; }
        public String Fono2 { get; set; }
        public String Comuna { get; set; }
        public String Nacionalidad { get; set; }
        public String Genero { get; set; }
        public int Activo { get; set; }

        
        public EnfermeraListar() 
        {
            Init();        
        }
        
        private void Init() 
        {
            Id = 0;            
            Rut = 0;
            Dv = '0';
            Foto = "0000";
            Pnombre = String.Empty;
            Snombre = String.Empty;
            Appaterno = String.Empty;
            Apmaterno = String.Empty;
            FechaNacimiento = DateTime.Now;
            Genero = String.Empty;
            Nacionalidad = String.Empty;
            Comuna = String.Empty;
            Direccion = String.Empty;
            Fono1 = String.Empty;
            Fono2 = String.Empty;
            Activo = 0;
        }
    }
}