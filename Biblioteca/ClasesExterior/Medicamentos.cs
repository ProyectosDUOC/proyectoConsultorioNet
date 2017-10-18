using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
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
    }
}
