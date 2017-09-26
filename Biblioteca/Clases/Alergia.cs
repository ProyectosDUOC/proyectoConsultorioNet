using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Control
{
    public class Alergia
    {
        private int id;
        private String nombre;
        private String descripcion;

        public Alergia() 
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            nombre = String.Empty;
            descripcion = String.Empty;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // sb.AppendFormat("Medico: rut Medico : {0}-{1} /n Especialidad : {2}", rutMedico, dvMedico, especialidad);
            sb.AppendFormat("id alegrgia: {0} nombre Alergia : {1}  Descripcion : {2} ", id, nombre, descripcion);
            return sb.ToString();
        }
    }
}
