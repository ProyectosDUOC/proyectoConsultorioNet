using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Control
{
    public class AlergiaPaciente
    {
        public int id_AlergiaPaciente { get; set; }
        public Alergia alergia;
        public Paciente paciente { get; set; }

        public AlergiaPaciente() {
            Init();
        }

        private void Init() {
            id_AlergiaPaciente = 0;
            alergia = null;
            paciente = null;
        }
    }
}
