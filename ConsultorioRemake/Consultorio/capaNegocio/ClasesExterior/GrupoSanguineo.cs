using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class GrupoSanguineo
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public GrupoSanguineo() {
            Init();
        }
        private void Init() {
            id = 0;
            nombre = String.Empty;
        }
        
        public bool Create() 
        {
            try
            {
                capaDatos.Grupo_sanguineo gruposangre = new capaDatos.Grupo_sanguineo();

                gruposangre.id_grupo_sanguineo = this.Id;
                gruposangre.nombre = this.Nombre;

                CommonBC.ModeloConsultorio.AddToGrupo_sanguineo(gruposangre);
                CommonBC.ModeloConsultorio.SaveChanges();
                
                return true;
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
                capaDatos.Grupo_sanguineo gruposangre =
                    CommonBC.ModeloConsultorio.Grupo_sanguineo.First 
                    (
                        gruposan => gruposan.id_grupo_sanguineo == this.Id
                    );

                this.Nombre = gruposangre.nombre;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update() 
        {
            try
            {
                capaDatos.Grupo_sanguineo gruposangre =
                    CommonBC.ModeloConsultorio.Grupo_sanguineo.First
                    (
                        gruposan => gruposan.id_grupo_sanguineo == this.Id
                    );

                gruposangre.nombre = this.Nombre;

                CommonBC.ModeloConsultorio.SaveChanges();

                return false;
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
                capaDatos.Grupo_sanguineo gruposangre =
                    CommonBC.ModeloConsultorio.Grupo_sanguineo.First
                    (
                        gruposan => gruposan.id_grupo_sanguineo == this.Id
                    );

                CommonBC.ModeloConsultorio.DeleteObject(gruposangre);
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
