using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;


namespace Biblioteca.Control
{
    public class RecetaMedica
    {
        public int idRecetaMedica { get; set; }
        public DateTime fechaIngreso { get; set; }
        public FichaPaciente idFichaPaciente { get; set; }
        public Medicamento medicamente { get; set; }


    }
}
