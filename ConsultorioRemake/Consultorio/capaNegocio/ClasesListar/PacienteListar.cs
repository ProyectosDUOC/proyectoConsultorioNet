using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio.ClasesListar
{
    public class PacienteListar
    {
       private int id; //por defecto    

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int rut; //validad rut

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;  //digito verificador

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private String foto; //ruta de la foto guardada

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private String pnombre;

        public String Pnombre
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
        private String snombre;

        public String Snombre
        {
            get { return snombre; }
            set { snombre = value; }
        }
        private String appaterno;

        public String Appaterno
        {
            get { return appaterno; }
            set { appaterno = value; }
        }
        private String apmaterno;

        public String Apmaterno
        {
            get { return apmaterno; }
            set { apmaterno = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private String fono1;

        public String Fono1
        {
            get { return fono1; }
            set { fono1 = value; }
        }
        private String fono2;

        public String Fono2
        {
            get { return fono2; }
            set { fono2 = value; }
        }
        private String comuna;

        public String Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }


        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        private String genero;

        public String Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        private String grupoSanguineo;
        public String GrupoSanguineo
        {
            get { return grupoSanguineo; }
            set { grupoSanguineo = value; }
        }
        private String rh;

        public String Rh
        {
            get { return rh; }
            set { rh = value; }
        }
        private String sector;

        public String Sector
        {
            get { return sector; }
            set { sector = value; }
        }

      
        
        public PacienteListar() 
        {
            Init();        
        }
        
        private void Init() 
        {
            id = 0;            
            rut = 0;
            dv = '0';
            foto = "0000";
            pnombre = String.Empty;
            snombre = String.Empty;
            appaterno = String.Empty;
            apmaterno = String.Empty;
            fechaNacimiento = DateTime.Now;
            genero = String.Empty;
            nacionalidad = String.Empty;
            comuna = String.Empty;
            direccion = String.Empty;
            fono1 = String.Empty;
            fono2 = String.Empty;
            activo = 0;
            grupoSanguineo = String.Empty;
            rh = String.Empty;
            sector = String.Empty;
        }
    }
}
