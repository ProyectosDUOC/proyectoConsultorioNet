using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;

namespace capaNegocio
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
        private int idTipoUsuario;

        public int IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }

        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }


        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public ControlAcceso()
        {
            Init();
        }

        private void Init()
        {
            id = 0;
            username = String.Empty;
            pass = String.Empty;
            idTipoUsuario = 0;
            idUsuario = 0;
            activo = 0;
        }

        public bool Create()
        {
            try
            {
                ConsultoriosEntities modelo = new ConsultoriosEntities();
                capaDatos.Control_Acceso controlAcceso = new capaDatos.Control_Acceso();

                controlAcceso.id_control_acceso = this.id;              
                controlAcceso.usuario = this.username;
                controlAcceso.contrasena = this.pass;
                controlAcceso.id_usuario= this.idUsuario;
                controlAcceso.id_tipo_usuario = this.IdTipoUsuario;
                controlAcceso.activo = this.Activo;

                modelo.AddToControl_Acceso(controlAcceso);
                modelo.SaveChanges();
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
                ConsultoriosEntities modelo = new ConsultoriosEntities();

                capaDatos.Control_Acceso controlAcceso = modelo.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.id
                    );

                this.Username = controlAcceso.usuario;
                this.Pass = controlAcceso.contrasena;
                this.idTipoUsuario = controlAcceso.id_tipo_usuario;
                this.idUsuario = controlAcceso.id_usuario;
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
                ConsultoriosEntities modelo = new ConsultoriosEntities();

                capaDatos.Control_Acceso controlAcceso = modelo.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.id
                    );
                controlAcceso.usuario = this.Username;
                controlAcceso.contrasena = this.Pass;
                controlAcceso.id_tipo_usuario = this.idTipoUsuario;
                controlAcceso.id_usuario = this.idUsuario;
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
                ConsultoriosEntities modelo = new ConsultoriosEntities();

                capaDatos.Control_Acceso controlAcceso = modelo.Control_Acceso.First
                    (
                        contro => contro.id_control_acceso == this.id
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
