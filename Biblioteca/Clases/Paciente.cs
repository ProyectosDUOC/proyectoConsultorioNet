using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Paciente
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
        private GrupoSanguineo grupoSanguineo;

        public GrupoSanguineo GrupoSanguineo
        {
            get { return grupoSanguineo; }
            set { grupoSanguineo = value; }
        }
        private Rh_sanguineo rh;

        public Rh_sanguineo Rh
        {
            get { return rh; }
            set { rh = value; }
        }
        private Sector sector;

        public Sector Sector
        {
            get { return sector; }
            set { sector = value; }
        }
              
        public Paciente() {
            Init();
        }
        private void Init() {
            id = 0;
            usuario = null;
            grupoSanguineo = null;
            rh = null;
            sector = null;
        }

        public bool Create() {
            try
            {                
              Consultiorios.DALC.Paciente paciente= new Consultiorios.DALC.Paciente();
             
              paciente.id_paciente = this.Id;
              paciente.id_usuario = this.Usuario.Id;
              paciente.id_grupo_sanguineo = this.GrupoSanguineo.Id;
              paciente.id_rh = this.Rh.Id;
              paciente.id_sector = this.Sector.Id;

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
                Consultiorios.DALC.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
                    (
                        pacien => pacien.id_paciente == this.Id
                    );
                this.Usuario.Id = paciente.id_usuario;
                this.GrupoSanguineo.Id = paciente.id_grupo_sanguineo;
                this.Rh.Id = paciente.id_rh;
                this.Sector.Id = paciente.id_sector;

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
                Consultiorios.DALC.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
                    (
                        pacien => pacien.id_paciente == this.Id
                    );
                paciente.id_usuario = this.Usuario.Id;
                paciente.id_grupo_sanguineo = this.GrupoSanguineo.Id;
                paciente.id_rh = this.Rh.Id;
                paciente.id_sector = this.Sector.Id;

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
                Consultiorios.DALC.Paciente paciente = CommonBC.ModeloConsultorio.Paciente.First
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
