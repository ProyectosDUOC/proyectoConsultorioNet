using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Enumeraciones;
using Biblioteca.Control;
using Biblioteca.Clases;

namespace Biblioteca
{
    public class Usuario
    {
        private int id; //por defecto    

        public ControlAcceso controlAcceso{set; get; }

        private int rut; //validad rut
        private char dv;  //digito verificador
        private String foto; //ruta de la foto guardada
       
        private String pnombre;
        private String snombre;
        private String appaterno;
        private String apmaterno;


        private DateTime fechaNacimiento;
        private String genero;

        private String nacionalidad;
        private String comuna;
        private String direccion;
        private String fono1;
        private String fono2;

        public int activo{ get; set; }
        


        public Usuario(int id, int rut, char dv, String foto, String pnombre, String snombre, String appaterno, String apmaterno) {
            this.id = id;
            this.rut = rut;
            this.dv = dv;
            this.foto = foto;
            this.pnombre = pnombre;
            this.snombre = snombre;
            this.appaterno = appaterno;
            this.apmaterno = apmaterno;
        }

        public Usuario() 
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

        public string Genero
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

        public string Comuna
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

        public String Nacionalidad
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
            sb.AppendFormat("User: {0} : pass {1} \n", controlAcceso.usuario.ToString(), controlAcceso.pass.ToString());
            sb.AppendFormat("Rut = {0}-{1} \n Nombre Completo: {2} {3} {4} {5} \n foto : {6} \n Fecha de Nacimiento: {7} \n Sexo: {8}", rut, dv, pnombre, snombre, appaterno, apmaterno, foto, fechaNacimiento, genero);
            sb.AppendFormat("\n Nacionalidad: {0} \n Comuna: {1} \n Direccion: {2} \n Fono 1: {3} \n Fono 2: {4} ", nacionalidad, comuna, direccion, fono1, fono2);
            sb.AppendFormat("ACtivo {0}", activo);
            return sb.ToString();
        }


    }
}
