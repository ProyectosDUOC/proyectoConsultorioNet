using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
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
                capaDatos.Enfermera enfermera = new capaDatos.Enfermera();

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
                capaDatos.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
                    (
                        enfer => enfer.id_usuario == this.idUsuario
                    );               
                this.id = enfermera.id_enfermera;
                this.idJornadaLaboral = (int)enfermera.id_jornada_laboral;

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
                capaDatos.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
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
                capaDatos.Enfermera enfermera = CommonBC.ModeloConsultorio.Enfermera.First
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
