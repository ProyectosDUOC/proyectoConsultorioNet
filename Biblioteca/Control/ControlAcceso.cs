using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class ControlAcceso
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String pass;

        public String Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        private TipoUsuario tipoUsuario;

        public TipoUsuario TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

      
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }      

        public ControlAcceso() {
            Init();
        }

        private void Init() {
            id = 0;
            username = String.Empty ;
            pass = String.Empty;
            tipoUsuario = null;
            usuario = null;
            activo = 0;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Control_Acceso controlAcceso = new Consultiorios.DALC.Control_Acceso();
                controlAcceso.id_control_acceso = this.Id;
                controlAcceso.usuario = this.Username;
                controlAcceso.contrasena = this.Pass;
                controlAcceso.id_tipo_usuario = this.TipoUsuario.Id;
                controlAcceso.id_usuario = this.Usuario.Id;
                controlAcceso.activo = this.Activo;
                CommonBC.ModeloConsultorio.AddToControl_Acceso(controlAcceso);
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
                Consultiorios.DALC.Control_Acceso controlAcceso = CommonBC.ModeloConsultorio.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.Id
                    );
               
                this.Username = controlAcceso.usuario;
                this.Pass = controlAcceso.contrasena;
                this.TipoUsuario.Id = controlAcceso.id_tipo_usuario;
                this.Usuario.Id = controlAcceso.id_usuario;
                this.Activo = (int)controlAcceso.activo;
                
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
                Consultiorios.DALC.Control_Acceso controlAcceso = CommonBC.ModeloConsultorio.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.Id
                    );

                controlAcceso.usuario = this.Username;
                controlAcceso.contrasena = this.Pass;
                controlAcceso.id_tipo_usuario = this.TipoUsuario.Id;
                controlAcceso.id_usuario = this.Usuario.Id;
                controlAcceso.activo = this.Activo;
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
                Consultiorios.DALC.Control_Acceso controlAcceso = CommonBC.ModeloConsultorio.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(controlAcceso);
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
