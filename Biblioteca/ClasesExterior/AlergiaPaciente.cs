using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.ClasesExterior
{
    public class AlergiaPaciente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Alergia alergia;

        public Alergia Alergia
        {
            get { return alergia; }
            set { alergia = value; }
        }
        private Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        } 

        public AlergiaPaciente()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            alergia = null;
            paciente = null;
        }
    }
}
