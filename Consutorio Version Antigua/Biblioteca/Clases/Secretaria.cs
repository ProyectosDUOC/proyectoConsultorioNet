using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Secretaria
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

   
        public Secretaria(){
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
                Consultiorios.DALC.Secretaria secretaria = new Consultiorios.DALC.Secretaria();

                secretaria.id_secretaria = this.Id;
                secretaria.id_usuario = this.IdUsuario;
                secretaria.id_jornada_laboral = this.IdJornadaLaboral;

                CommonBC.ModeloConsultorio.AddToSecretaria(secretaria);
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
                Consultiorios.DALC.Secretaria secretaria = CommonBC.ModeloConsultorio.Secretaria.First
                    (
                        secre => secre.id_secretaria == this.Id
                    );               
                this.IdUsuario = secretaria.id_usuario;
                this.IdJornadaLaboral = secretaria.id_jornada_laboral;

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
                Consultiorios.DALC.Secretaria secretaria = CommonBC.ModeloConsultorio.Secretaria.First
                    (
                        secre => secre.id_secretaria == this.Id
                    );

                secretaria.id_usuario = this.IdUsuario;
                secretaria.id_jornada_laboral = this.IdJornadaLaboral;
               
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
                Consultiorios.DALC.Secretaria secretaria = CommonBC.ModeloConsultorio.Secretaria.First
                    (
                        secre => secre.id_secretaria == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(secretaria);
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
