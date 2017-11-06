using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class TipoDesvinculado
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

        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public TipoDesvinculado() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            glosa = String.Empty;
        }

        public bool Create()
        {
            try
            {
                capaDatos.Tipo_Desvinculado desv = new capaDatos.Tipo_Desvinculado();

                desv.id_tipo_desvin = this.Id;
                desv.nombre = this.Nombre;
                desv.glosa = this.Glosa;

                CommonBC.ModeloConsultorio.AddToTipo_Desvinculado(desv);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                capaDatos.Tipo_Desvinculado desv = CommonBC.ModeloConsultorio.Tipo_Desvinculado.
                                                                    First(d => d.id_tipo_desvin == this.Id);

                this.Nombre = desv.nombre;
                this.Glosa = desv.glosa;

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
                capaDatos.Tipo_Desvinculado desv = CommonBC.ModeloConsultorio.Tipo_Desvinculado.
                                                                    First(d => d.id_tipo_desvin == this.Id);
                desv.nombre = this.Nombre;
                desv.glosa = this.Glosa;

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
                capaDatos.Tipo_Desvinculado desv = CommonBC.ModeloConsultorio.Tipo_Desvinculado.
                                                                   First(d => d.id_tipo_desvin == this.Id);
                CommonBC.ModeloConsultorio.DeleteObject(desv);
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
