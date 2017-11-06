using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Paciente
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


        private int idGrupoSanguineo;

        public int IdGrupoSanguineo
        {
            get { return idGrupoSanguineo; }
            set { idGrupoSanguineo = value; }
        }


        private int idRh;

        public int IdRh
        {
            get { return idRh; }
            set { idRh = value; }
        }

        private int idSector;

        public int IdSector
        {
            get { return idSector; }
            set { idSector = value; }
        }

    
              
        public Paciente() {
            Init();
        }
        private void Init() {
            id = 0;
            idUsuario = 0;
            idGrupoSanguineo = 0;
            idRh = 0;
            idSector = 0;
        }

        public bool Create() {
            try
            {                
              capaDatos.Paciente paciente= new capaDatos.Paciente();
             
              paciente.id_paciente = this.Id;
              paciente.id_usuario = this.IdUsuario;
              paciente.id_grupo_sanguineo = this.IdGrupoSanguineo;
              paciente.id_rh = this.IdRh;
              paciente.id_sector = this.IdSector;

              CommonBC.ModeloConsultorio.AddToPaciente(paciente);
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
                capaDatos.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
                    (
                        pacien => pacien.id_paciente == this.Id
                    );
                this.IdUsuario = paciente.id_usuario;
                this.IdGrupoSanguineo = paciente.id_grupo_sanguineo;
                this.IdRh = paciente.id_rh;
                this.IdSector = paciente.id_sector;

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
                capaDatos.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
                    (
                        pacien => pacien.id_paciente == this.Id
                    );
                paciente.id_usuario = this.IdUsuario;
                paciente.id_grupo_sanguineo = this.IdGrupoSanguineo;
                paciente.id_rh = this.IdRh;
                paciente.id_sector = this.IdSector;

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
                capaDatos.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
                    (
                        pacien => pacien.id_paciente == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(paciente);
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
