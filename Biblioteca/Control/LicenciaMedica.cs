using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Control
{
    public class LicenciaMedica
    {
        private uint idLicencia;

        private DateTime fecha;
        private Medico medico;
        private Paciente paciente;       
        private int numeroDias;
        private string motivo;

        public LicenciaMedica() 
        {
            Init();
        }

        private void Init()
        {
            idLicencia = 0;
            fecha = DateTime.Now;
            medico = null;
            paciente = null;
            numeroDias = 0;
            motivo = String.Empty;

        }

        public uint IdLicencia
        {
            get { return idLicencia; }
            set { idLicencia = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }    
        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }
        public int NumeroDias
        {
            get { return numeroDias; }
            set { numeroDias = value; }
        }
        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("N° {0}",idLicencia);
            sb.AppendFormat("Fecha:{0} ", fecha);
            sb.AppendFormat("Paciente: {0} , Medico {1}" , paciente, medico );
            sb.AppendFormat("numeros de dias {0} , motivo {1}", numeroDias, motivo);
            return sb.ToString();
        }

    }
}
