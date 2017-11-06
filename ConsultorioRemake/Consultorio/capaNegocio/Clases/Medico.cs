using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
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
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


        private int idEspecialidad;

        public int IdEspecialidad
        {
            get { return idEspecialidad; }
            set { idEspecialidad = value; }
        }


        private int idJornadaLaboral;

        public int IdJornadaLaboral
        {
            get { return idJornadaLaboral; }
            set { idJornadaLaboral = value; }
        }

       
        private void Init() {
            id = 0;
            rut = 0;
            dv = '0';
            idUsuario = 0;
            idEspecialidad = 0;
            idJornadaLaboral = 0;
        }

        public bool Create() {
            try
            {
                capaDatos.Medico medico = new capaDatos.Medico();

                medico.id_Medico = this.Id;
                medico.rut_medico = this.Rut;
                medico.dv_medico = this.Dv.ToString();
                medico.id_usuario = this.IdUsuario;
                medico.id_especialidad = this.IdEspecialidad;
                medico.id_jornada_laboral = this.IdJornadaLaboral;

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
                capaDatos.Medico medico = CommonBC.ModeloConsultorio.Medico.First
                    (
                        medi => medi.id_Medico == this.Id
                    );
                this.Rut = medico.rut_medico;
                this.Dv = Char.Parse(medico.dv_medico);
                this.IdUsuario= medico.id_usuario;
                this.IdEspecialidad = medico.id_especialidad;
                this.IdJornadaLaboral = medico.id_jornada_laboral;

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
                capaDatos.Medico medico = CommonBC.ModeloConsultorio.Medico.First
                    (
                        medi => medi.id_Medico == this.Id                    
                    );
                medico.rut_medico = this.Rut;
                medico.dv_medico = this.Dv.ToString();
                medico.id_usuario = this.IdUsuario;
                medico.id_especialidad = this.IdEspecialidad;
                medico.id_jornada_laboral = this.IdJornadaLaboral;

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
                capaDatos.Medico medico = CommonBC.ModeloConsultorio.Medico.First
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
