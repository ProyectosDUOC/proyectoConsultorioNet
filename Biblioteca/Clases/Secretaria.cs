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
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private JornadaLaboral jornadaLaboral;

        public JornadaLaboral JornadaLaboral
        {
            get { return jornadaLaboral; }
            set { jornadaLaboral = value; }
        }

        public Secretaria(){
            Init();
        }

        private void Init(){
            id = 0;
            usuario = null;
            jornadaLaboral = null;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Secretaria secretaria = new Consultiorios.DALC.Secretaria();

                secretaria.id_secretaria = this.Id;
                secretaria.id_usuario = this.Usuario.Id;
                secretaria.id_jornada_laboral = this.JornadaLaboral.Id;

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
                this.Usuario.Id = secretaria.id_usuario;
                this.JornadaLaboral.Id = secretaria.id_jornada_laboral;

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

                secretaria.id_usuario = this.Usuario.Id;
                secretaria.id_jornada_laboral = this.JornadaLaboral.Id;
               
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
