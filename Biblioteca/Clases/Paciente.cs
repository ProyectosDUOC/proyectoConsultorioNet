using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Enumeraciones;

namespace Biblioteca.Clases
{
    public class Paciente: Usuario
    {
        private int idPaciente;
     
        private String sector;
        private String grupoSanguineo;
        private String rh;
        private String alergia; // cambiar por la clase Alergia

        public Paciente() 
        {
            Init();
        }
        private void Init() 
        {
            idPaciente = 0;
            sector = String.Empty;
            grupoSanguineo = String.Empty;
            rh = String.Empty;
            alergia = String.Empty;
        }

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        public string Sector
        {
            get
            {
                return sector;
            }

            set
            {
                sector = value;
            }
        }
        public string GrupoSanguineo
        {
            get
            {
                return grupoSanguineo;
            }

            set
            {
                grupoSanguineo = value;
            }
        }
        public string Rh
        {
            get
            {
                return rh;
            }

            set
            {
                rh = value;
            }
        }
        public string Alergia
        {
            get
            {
                return alergia;
            }

            set
            {
                alergia = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Paciente {1}",idPaciente);
            sb.AppendFormat(base.ToString());
            sb.AppendFormat("Sector {0} \n grupo Sanguineo {1} , rh {2} , alergia {3}", sector, grupoSanguineo, rh, alergia);
            
            return sb.ToString();
        }
    }
}
