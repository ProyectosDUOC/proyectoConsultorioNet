using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Enumeraciones;

namespace Biblioteca
{
    public class Usuario
    {
        private int id; //por defecto    

        private String user;
        private String contrasena;

        private int rut; //validad rut
        private char dv;  //digito verificador
        private String foto; //ruta de la foto guardada
       
        private String pnombre;
        private String snombre;
        private String appaterno;
        private String apmaterno;


        private DateTime fechaNacimiento;
        private Genero genero;

        private Nacionalidad nacionalidad;
        private Comuna comuna;
        private String direccion;
        private String fono1;
        private String fono2;


        public Usuario(int id, int rut, char dv, String foto, String pnombre) {
            this.id = id;
            this.rut = rut;
            this.dv = dv;
            this.foto = foto;
            this.pnombre = pnombre;        
        }

        public Usuario() 
        {
            Init();        
        }



        private void Init() 
        {
            id = 0;
            user = String.Empty;
            contrasena = String.Empty;
            rut = 0;
            dv = '0';
            foto = "1000";
            pnombre = String.Empty;
            snombre = String.Empty;
            appaterno = String.Empty;
            apmaterno = String.Empty;
            fechaNacimiento = DateTime.Now;
            genero = Genero.Seleccione;
            nacionalidad = Nacionalidad.Seleccione;
            comuna = Comuna.Seleccione;
            direccion = String.Empty;
            fono1 = String.Empty;
            fono2 = String.Empty;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public int Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public char Dv
        {
            get
            {
                return dv;
            }

            set
            {
                dv = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public string Pnombre
        {
            get
            {
                return pnombre;
            }

            set
            {
                pnombre = value;
            }
        }

        public string Snombre
        {
            get
            {
                return snombre;
            }

            set
            {
                snombre = value;
            }
        }

        public string Appaterno
        {
            get
            {
                return appaterno;
            }

            set
            {
                appaterno = value;
            }
        }

        public string Apmaterno
        {
            get
            {
                return apmaterno;
            }

            set
            {
                apmaterno = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public Genero Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public Comuna Comuna
        {
            get
            {
                return comuna;
            }

            set
            {
                comuna = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Fono1
        {
            get
            {
                return fono1;
            }

            set
            {
                fono1 = value;
            }
        }

        public string Fono2
        {
            get
            {
                return fono2;
            }

            set
            {
                fono2 = value;
            }
        }

        public Nacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }

            set
            {
                nacionalidad = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("User: {0} : pass {1} \n", user, contrasena);
            sb.AppendFormat("Rut = {0}-{1} \n Nombre Completo: {2} {3} {4} {5} \n foto : {6} \n Fecha de Nacimiento: {7} \n Sexo: {8}", rut, dv, pnombre, snombre, appaterno, apmaterno, foto, fechaNacimiento, genero);
            sb.AppendFormat("\n Nacionalidad: {0} \n Comuna: {1} \n Direccion: {2} \n Fono 1: {3} \n Fono 2: {4} ", nacionalidad, comuna, direccion, fono1, fono2);
            return sb.ToString();
        }


    }
}
