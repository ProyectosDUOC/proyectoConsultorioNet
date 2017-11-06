using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class TipoUsuario
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

        public TipoUsuario() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
        }

        public bool Create() {
            try
            {
                capaDatos.Tipo_Usuario tipoUsuario = new capaDatos.Tipo_Usuario();

                tipoUsuario.id_tipo_usuario = this.Id;
                tipoUsuario.nom_tipo_usuario = this.Nombre;
                CommonBC.ModeloConsultorio.AddToTipo_Usuario(tipoUsuario);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }
        public bool Read() {
            try
            {
                capaDatos.Tipo_Usuario tipoUsuario = CommonBC.ModeloConsultorio.Tipo_Usuario.First
                    (
                        tipo => tipo.id_tipo_usuario == this.Id
                    );
             
                this.Nombre = tipoUsuario.nom_tipo_usuario;
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
                capaDatos.Tipo_Usuario tipoUsuario = CommonBC.ModeloConsultorio.Tipo_Usuario.First
                    (
                        tipo => tipo.id_tipo_usuario == this.Id
                    );
               
                tipoUsuario.nom_tipo_usuario = this.Nombre;
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
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
                capaDatos.Tipo_Usuario tipoUsuario = CommonBC.ModeloConsultorio.Tipo_Usuario.First
                    (
                        tipo => tipo.id_tipo_usuario == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(tipoUsuario);
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
