using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class Medico: Usuario
    {
        private int idMedico;
        private int rutMedico;
        private char dvMedico;
        private Especialidad especialidad;


        public Medico() 
        {
            Init();
        }
        private void Init() 
        {
            idMedico = 0;
            rutMedico = 0;
            dvMedico = '0';
            especialidad = Especialidad.Seleccione;        
        }

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }
        public int RutMedico
        {
            get
            {
                return rutMedico;
            }

            set
            {
                rutMedico = value;
            }
        }
        public char DvMedico
        {
            get
            {
                return dvMedico;
            }

            set
            {
                dvMedico = value;
            }
        }
        public Especialidad Especialidad
        {
            get
            {
                return especialidad;
            }

            set
            {
                especialidad = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Medico {3}: rut Medico : {0}-{1} /n Especialidad : {2}", rutMedico, dvMedico, especialidad, idMedico);
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
