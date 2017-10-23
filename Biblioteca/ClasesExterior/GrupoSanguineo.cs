using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.ClasesExterior
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
                Consultiorios.DALC.Grupo_sanguineo gruposangre = new Consultiorios.DALC.Grupo_sanguineo();

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
                Consultiorios.DALC.Grupo_sanguineo gruposangre =
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
                Consultiorios.DALC.Grupo_sanguineo gruposangre =
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
                Consultiorios.DALC.Grupo_sanguineo gruposangre =
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
