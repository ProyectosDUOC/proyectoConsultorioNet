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
        private int idusuario;

        public int idUsuario
        {
            get { return idusuario; }
            set { usuario = value; }
        }
        private JornadaLaboral jornadaLaboral;

        public JornadaLaboral JornadaLaboral
        {
            get { return jornadaLaboral; }
            set { jornadaLaboral = value; }
        }

        public Enfermera(){
            Init();
        }

        private void Init(){
            id = 0;
            usuario = 0;
            jornadaLaboral = null;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Enfermera enfermera = new Consultiorios.DALC.Enfermera();

                enfermera.id_enfermera = this.Id;
                enfermera.id_usuario = this.idusuario;
                enfermera.id_jornada_laboral = this.JornadaLaboral.Id;

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
                this.Usuario.Id = enfermera.id_usuario;
                this.JornadaLaboral.Id = enfermera.id_jornada_laboral;

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
                enfermera.id_usuario = this.Usuario.Id;
                enfermera.id_jornada_laboral = this.JornadaLaboral.Id;

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
