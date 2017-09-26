using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Enumeraciones;

namespace Biblioteca.Clases
{
    public class Paciente: Usuario
    {
        private uint idPaciente;
     
        private Sector sector;
        private GrupoSanguineo grupoSanguineo;
        private RhSanguineo rh;
        private String alergia; // cambiar por la clase Alergia

        public Paciente() 
        {
            Init();
        }
        private void Init() 
        {
            idPaciente = 0;
            sector = Sector.Seleccione;
            grupoSanguineo = GrupoSanguineo.Seleccione;
            rh = RhSanguineo.Seleccione;
            alergia = String.Empty;
        }

        public uint IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }
        public Sector Sector
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
        public GrupoSanguineo GrupoSanguineo
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
        public RhSanguineo Rh
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
