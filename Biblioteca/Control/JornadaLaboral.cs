using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Control
{
    public class JornadaLaboral
    {
        public int id { get; set; }
        public int lunes { get; set; }
        public int martes { get; set; }
        public int miercoles { get; set; }
        public int jueves { get; set; }
        public int viernes { get; set; }
        public int sabado { get; set; }
        public int domingo { get; set; }
        public Sector sector { get; set; }
     
    }
}
