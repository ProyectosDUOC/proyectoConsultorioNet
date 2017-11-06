using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Desvinculado
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

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int idTipoDesvinculado;

        public int IdTipoDesvinculado
        {
            get { return idTipoDesvinculado; }
            set { idTipoDesvinculado = value; }
        }

       
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public Desvinculado() {
            Init();
        }

        private void Init() {
            id = 0;
            idUsuario = 0;
            fecha = DateTime.Now;
            idTipoDesvinculado = 0;
            glosa = String.Empty;
        }

        public bool Create() 
        {
            try 
            { 
                
                capaDatos.Desvinculado desvinculado = new capaDatos.Desvinculado();
                //parte BD                     //parte clase 
                desvinculado.id_desvinculado = this.Id;
                desvinculado.id_usuario = this.IdUsuario;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.IdTipoDesvinculado;
                desvinculado.glosa = this.Glosa;

                CommonBC.ModeloConsultorio.AddToDesvinculado(desvinculado);
                CommonBC.ModeloConsultorio.SaveChanges();


                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Read() 
        {
            try 
            {
                capaDatos.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                this.IdUsuario = desvinculado.id_usuario;
                this.Fecha = (DateTime)desvinculado.fecha;
                this.idTipoDesvinculado = desvinculado.id_tipo_desvin;
                this.Glosa = desvinculado.glosa;

                return true;
            }
            catch(Exception ex)
            {
                return false;   
            }
        }

        public bool Update()
        {
            try
            {
                capaDatos.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                desvinculado.id_usuario = this.IdUsuario;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.IdTipoDesvinculado;
                desvinculado.glosa = this.Glosa;

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
                capaDatos.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );


                CommonBC.ModeloConsultorio.DeleteObject(desvinculado);
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
