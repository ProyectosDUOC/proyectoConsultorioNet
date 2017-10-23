using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;


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

        public bool Create() 
        {
            try
            {
                Consultiorios.DALC.Jornada_laboral jornadalaboral = new Consultiorios.DALC.Jornada_laboral();

                jornadalaboral.id_jornada_laboral = this.Id;
                jornadalaboral.lunes = this.Lunes;
                jornadalaboral.martes = this.Martes;
                jornadalaboral.miercoles = this.Miercoles;
                jornadalaboral.jueves = this.Jueves;
                jornadalaboral.viernes = this.Viernes;
                jornadalaboral.sabado = this.Sabado;
                jornadalaboral.domingo = this.Domingo;

                CommonBC.ModeloConsultorio.AddToJornada_laboral(jornadalaboral);
                CommonBC.ModeloConsultorio.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read() 
        {
            try
            {
                Consultiorios.DALC.Jornada_laboral jornadalaboral =
                    CommonBC.ModeloConsultorio.Jornada_laboral.First
                    (
                        jor => jor.id_jornada_laboral == this.Id
                    );
                //buscar como exportar
                this.Lunes = jornadalaboral.lunes ;
                this.Martes = jornadalaboral.martes;
                this.Miercoles = jornadalaboral.miercoles;
                this.Jueves = jornadalaboral.jueves;
                this.Viernes = jornadalaboral.viernes;
                this.Sabado = jornadalaboral.sabado ;
                this.Domingo = jornadalaboral.domingo;

                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool Update ()
        {
            try
            {
                Consultiorios.DALC.Jornada_laboral jornadalaboral =
                    CommonBC.ModeloConsultorio.Jornada_laboral.First
                    (
                        jor => jor.id_jornada_laboral == this.Id
                    );

                jornadalaboral.lunes = this.Lunes;
                jornadalaboral.martes = this.Martes;
                jornadalaboral.miercoles = this.Miercoles;
                jornadalaboral.jueves = this.Jueves;
                jornadalaboral.viernes = this.Viernes;
                jornadalaboral.sabado = this.Sabado;
                jornadalaboral.domingo = this.Domingo;

                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public bool Delete() 
        {
            try
            {
                Consultiorios.DALC.Jornada_laboral jornadalaboral =
                    CommonBC.ModeloConsultorio.Jornada_laboral.First
                    (
                        jor => jor.id_jornada_laboral == this.Id
                    );

                CommonBC.ModeloConsultorio.DeleteObject(jornadalaboral);
                CommonBC.ModeloConsultorio.SaveChanges();

                return false;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }




    }
}
