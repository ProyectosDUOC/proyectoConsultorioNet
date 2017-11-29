using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Medicamentos
    {
          private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String principioActivo;

        public String PrincipioActivo
        {
            get { return principioActivo; }
            set { principioActivo = value; }
        }
        private String productoReferencia;

        public String ProductoReferencia
        {
            get { return productoReferencia; }
            set { productoReferencia = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private String codigoRegistro;

        public String CodigoRegistro
        {
            get { return codigoRegistro; }
            set { codigoRegistro = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }


        public Medicamentos() {
            Init();
        }

        private void Init() {
            id = 0;
            principioActivo = String.Empty;
            nombre = String.Empty;
            productoReferencia = String.Empty;
            codigoRegistro = String.Empty;
            glosa = String.Empty;
        }


        public bool Create() 
        {
            try
            {
                capaDatos.Medicamentos medicamentos = new capaDatos.Medicamentos();

                medicamentos.id_medicamentos = this.Id;
                medicamentos.principio_activo = this.PrincipioActivo;
                medicamentos.nombre_producto = this.Nombre;
                medicamentos.producto_referencia = this.ProductoReferencia;
                medicamentos.codigo_registro = this.CodigoRegistro;
                medicamentos.glosa = this.Glosa;

                CommonBC.ModeloConsultorio.AddToMedicamentos(medicamentos);
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
                capaDatos.Medicamentos medicamentos = 
                    CommonBC.ModeloConsultorio.Medicamentos.First
                    (
                        medik => medik.id_medicamentos == this.Id 
                    );

                this.PrincipioActivo = medicamentos.principio_activo;
                this.Nombre = medicamentos.nombre_producto;
                this.ProductoReferencia = medicamentos.producto_referencia;
                this.CodigoRegistro = medicamentos.codigo_registro;
                this.Glosa = medicamentos.glosa;

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool ReadNombre()
        {
            try
            {
                capaDatos.Medicamentos medicamentos =
                    CommonBC.ModeloConsultorio.Medicamentos.First
                    (
                        medik => medik.nombre_producto == this.nombre
                    );
                this.id = medicamentos.id_medicamentos;
                this.PrincipioActivo = medicamentos.principio_activo;
                this.Nombre = medicamentos.nombre_producto;
                this.ProductoReferencia = medicamentos.producto_referencia;
                this.CodigoRegistro = medicamentos.codigo_registro;
                this.Glosa = medicamentos.glosa;

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
                capaDatos.Medicamentos medicamentos =
                    CommonBC.ModeloConsultorio.Medicamentos.First
                    (
                        medik => medik.id_medicamentos == this.Id
                    );

                medicamentos.id_medicamentos = this.Id;
                medicamentos.principio_activo = this.PrincipioActivo;
                medicamentos.nombre_producto = this.Nombre;
                medicamentos.producto_referencia = this.ProductoReferencia;
                medicamentos.codigo_registro = this.CodigoRegistro;
                medicamentos.glosa = this.Glosa;

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
                capaDatos.Medicamentos medicamentos =
                    CommonBC.ModeloConsultorio.Medicamentos.First
                    (
                        medik => medik.id_medicamentos == this.Id
                    );

                CommonBC.ModeloConsultorio.DeleteObject(medicamentos);
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
