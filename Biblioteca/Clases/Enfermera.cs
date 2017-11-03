using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Enfermera
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }

        }

        
        private int idJornadaLaboral;

        public int IdJornadaLaboral
        {
            get { return idJornadaLaboral; }
            set { idJornadaLaboral = value; }
        }


        public Enfermera(){
            Init();
        }

        private void Init(){
            id = 0;
            idUsuario = 0;
            idJornadaLaboral = 0;

        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Enfermera enfermera = new Consultiorios.DALC.Enfermera();

                enfermera.id_enfermera = this.Id;

                enfermera.id_usuario = this.idUsuario;
                enfermera.id_jornada_laboral = this.idJornadaLaboral;


                CommonBC.ModeloConsultorio.AddToEnfermera(enfermera);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }
        }

        public bool Read() {
            try
            {
                Consultiorios.DALC.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
                    (
                        enfer => enfer.id_enfermera == this.Id
                    );               
                this.idUsuario = enfermera.id_usuario;
                this.idJornadaLaboral = enfermera.id_jornada_laboral;

                return true;
            }
            catch (Exception ex)
            {                
               return false;
            }        
        }

        public bool Update() {
            try
            {
                Consultiorios.DALC.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
                    (
                        enfer => enfer.id_enfermera == this.Id
                     );              
                enfermera.id_usuario = this.idUsuario;
                enfermera.id_jornada_laboral = this.idJornadaLaboral;

                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }        
        }
        public bool Delete() {
            try
            {
                Consultiorios.DALC.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
                    (
                        enfer => enfer.id_enfermera == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(enfermera);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }        
        }
        
        

    }
}
