using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;
using Biblioteca;

namespace Biblioteca.ClasesExterior
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
                
                Consultiorios.DALC.Desvinculado desvinculado = new Consultiorios.DALC.Desvinculado();
                //parte BD                     //parte clase 
                desvinculado.id_desvinculado = this.Id;
                desvinculado.id_usuario = this.IdUsuario;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.TipoDesvinculado.Id;
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
                Consultiorios.DALC.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                this.IdUsuario = desvinculado.id_usuario;
                this.Fecha = (DateTime)desvinculado.fecha;
                this.TipoDesvinculado.Id = desvinculado.id_tipo_desvin;
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
                Consultiorios.DALC.Desvinculado desvinculado =
                    CommonBC.ModeloConsultorio.Desvinculado.First
                        (
                            des => des.id_desvinculado == this.Id
                        );

                desvinculado.id_usuario = this.IdUsuario;
                desvinculado.fecha = this.Fecha;
                desvinculado.id_tipo_desvin = this.TipoDesvinculado.Id;
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
                Consultiorios.DALC.Desvinculado desvinculado =
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
