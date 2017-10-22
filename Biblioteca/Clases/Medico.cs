using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Medico
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private Especialidad especialidad;

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        private JornadaLaboral jornadaLaboral;

        public JornadaLaboral JornadaLaboral
        {
            get { return jornadaLaboral; }
            set { jornadaLaboral = value; }
        }
        private void Init() {
            id = 0;
            rut = 0;
            dv = '0';
            usuario = null;
            especialidad = null;
            jornadaLaboral = null;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Medico medico = new Consultiorios.DALC.Medico();

                medico.id_Medico = this.Id;
                medico.rut_medico = this.Rut;
                medico.dv_medico = this.Dv.ToString();
                medico.id_usuario = this.Usuario.Id;
                medico.id_especialidad = this.Especialidad.Id;
                medico.id_jornada_laboral = this.JornadaLaboral.Id;

                CommonBC.ModeloConsultorio.AddToMedico(medico);
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
                Consultiorios.DALC.Medico medico = CommonBC.ModeloConsultorio.Medico.First
                    (
                        medi => medi.id_Medico == this.Id
                    );
                this.Rut = medico.rut_medico;
                this.Dv = Char.Parse(medico.dv_medico);
                this.usuario.Id = medico.id_usuario;
                this.especialidad.Id = medico.id_especialidad;
                this.jornadaLaboral.Id = medico.id_jornada_laboral;

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
                Consultiorios.DALC.Medico medico = CommonBC.ModeloConsultorio.Medico.First
                    (
                        medi => medi.id_Medico == this.Id                    
                    );
                medico.rut_medico = this.Rut;
                medico.dv_medico = this.Dv.ToString();
                medico.id_usuario = this.Usuario.Id;
                medico.id_especialidad = this.Especialidad.Id;
                medico.id_jornada_laboral = this.JornadaLaboral.Id;

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
                Consultiorios.DALC.Medico medico = CommonBC.ModeloConsultorio.Medico.First
                    (
                        med => med.id_Medico == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(medico);
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
