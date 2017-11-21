using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio
{
    public class Usuario
    {
        private int id; //por defecto    

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int rut; //validad rut

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;  //digito verificador

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private String foto; //ruta de la foto guardada

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private String pnombre;

        public String Pnombre
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
        private String snombre;

        public String Snombre
        {
            get { return snombre; }
            set { snombre = value; }
        }
        private String appaterno;

        public String Appaterno
        {
            get { return appaterno; }
            set { appaterno = value; }
        }
        private String apmaterno;

        public String Apmaterno
        {
            get { return apmaterno; }
            set { apmaterno = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private String fono1;

        public String Fono1
        {
            get { return fono1; }
            set { fono1 = value; }
        }
        private String fono2;

        public String Fono2
        {
            get { return fono2; }
            set { fono2 = value; }
        }
        private int idComuna;

        public int IdComuna
        {
            get { return idComuna; }
            set { idComuna = value; }
        }


        private int idNacionalidad;

        public int IdNacionalidad
        {
            get { return idNacionalidad; }
            set { idNacionalidad = value; }
        }
        private int idGenero;

        public int IdGenero
        {
            get { return idGenero; }
            set { idGenero = value; }
        }

        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    
        public Usuario() 
        {
            Init();        
        }
        
        private void Init() 
        {
            id = 0;            
            rut = 0;
            dv = '0';
            foto = "0000";
            pnombre = String.Empty;
            snombre = String.Empty;
            appaterno = String.Empty;
            apmaterno = String.Empty;
            fechaNacimiento = DateTime.Now;
            idGenero = 0;
            idNacionalidad = 0;
            idComuna = 0;
            direccion = String.Empty;
            fono1 = String.Empty;
            fono2 = String.Empty;
            activo = 0;
        }

        public String imprimir() {
            return id +" " +rut +"-" + dv +"   "+ foto+" "+ pnombre +" "+ snombre+ "  " + appaterno+ "  " + apmaterno;
        }
        

        public bool Create() {
            try
            {
                capaDatos.Usuario usuario = new capaDatos.Usuario();

                usuario.id_usuario = this.Id;
                usuario.rut_usuario = this.Rut;
                usuario.dv_usuario = this.Dv.ToString();
                usuario.foto = this.Foto;
                usuario.pnombre = this.Pnombre;
                usuario.snombre = this.Snombre;
                usuario.appaterno = this.Appaterno;
                usuario.apmaterno = this.Apmaterno;
                usuario.fecha_nacimiento = this.FechaNacimiento;
                usuario.id_genero = this.IdGenero;
                usuario.id_nacionalidad = this.IdNacionalidad;
                usuario.id_comuna = this.IdComuna;
                usuario.direccion = this.Direccion;
                usuario.fono1 = int.Parse(this.Fono1);
                usuario.fono2 = int.Parse(this.Fono2);
                usuario.activo = this.Activo;

                CommonBC.ModeloConsultorio.AddToUsuario(usuario);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
               return false;
            }
        }
        public bool ReadRut()
        {
            try
            {
                capaDatos.Usuario usuario = CommonBC.ModeloConsultorio.Usuario.First
                    (
                        usu => usu.rut_usuario == this.rut
                    );
                
                this.id = usuario.id_usuario;
                this.rut = usuario.rut_usuario;
                this.dv = Char.Parse(usuario.dv_usuario);
                this.foto = usuario.foto;
                this.pnombre = usuario.pnombre;
                this.snombre = usuario.snombre;
                this.appaterno = usuario.appaterno;
                this.apmaterno = usuario.apmaterno;
                this.fechaNacimiento = usuario.fecha_nacimiento;
                this.idGenero = usuario.id_genero;
                this.idNacionalidad = usuario.id_nacionalidad;
                this.idComuna = usuario.id_comuna;
                this.direccion = usuario.direccion;
                this.fono1 = usuario.fono1.ToString();
                this.fono2 = usuario.fono2.ToString();
                this.activo = usuario.activo;

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
                capaDatos.Usuario usuario = CommonBC.ModeloConsultorio.Usuario.First
                    (
                        usu => usu.id_usuario == this.id
                    );
                this.Rut = usuario.rut_usuario;
                this.Dv = Char.Parse(usuario.dv_usuario);
                this.Foto = usuario.foto;
                this.Pnombre = usuario.pnombre;
                this.Snombre = usuario.snombre;
                this.Appaterno = usuario.appaterno;
                this.Apmaterno = usuario.apmaterno;
                this.FechaNacimiento = usuario.fecha_nacimiento;
                this.IdGenero = usuario.id_genero;
                this.IdNacionalidad = usuario.id_nacionalidad;
                this.IdComuna = usuario.id_comuna;
                this.Direccion = usuario.direccion;
                this.Fono1 = usuario.fono1.ToString();
                this.Fono2 = usuario.fono2.ToString();
                this.Activo = usuario.activo;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateNuevo() {
            try
            {
                ConsultoriosEntities modelo = new ConsultoriosEntities();

                capaDatos.Usuario usuario = modelo.Usuario.First
                    (
                        usu => usu.rut_usuario == this.rut
                    );
                usuario.rut_usuario = this.rut;
                usuario.dv_usuario = this.dv.ToString();
               // usuario.foto = this.foto;
                usuario.pnombre = this.pnombre;
                usuario.snombre = this.snombre;
                usuario.appaterno = this.appaterno;
                usuario.apmaterno = this.apmaterno;
                usuario.fecha_nacimiento = this.fechaNacimiento;
                usuario.id_genero= this.idGenero;
                usuario.id_nacionalidad = this.idNacionalidad;
                usuario.id_comuna = this.idComuna;
                usuario.direccion = this.direccion;
                usuario.fono1 = int.Parse(this.fono1);
                usuario.fono2 = int.Parse(this.fono2);
               // usuario.activo = this.activo;

                modelo.SaveChanges();
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

                capaDatos.Usuario usuario = CommonBC.ModeloConsultorio.Usuario.First
                    (
                        usu => usu.rut_usuario == this.rut
                    );
                usuario.rut_usuario = this.rut;
                usuario.dv_usuario = this.dv.ToString();
                usuario.foto = this.foto;
                usuario.pnombre = this.pnombre;
                usuario.snombre = this.snombre;
                usuario.appaterno = this.appaterno;
                usuario.apmaterno = this.apmaterno;
                usuario.fecha_nacimiento = this.fechaNacimiento;
                usuario.id_genero = this.idGenero;
                usuario.id_nacionalidad = this.idNacionalidad;
                usuario.id_comuna = this.idComuna;
                usuario.direccion = this.direccion;
                usuario.fono1 = int.Parse(this.fono1);
                usuario.fono2 = int.Parse(this.fono2);
                usuario.activo = this.activo;

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
                capaDatos.Usuario usuario = CommonBC.ModeloConsultorio.Usuario.First
                    (
                        usua => usua.id_usuario == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(usuario);
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
