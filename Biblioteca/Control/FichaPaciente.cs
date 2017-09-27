using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Control
{
    public class FichaPaciente
    {
        public uint idfichaMedica { get; set; }
        private DateTime fechaIngreso { get; set; }

        private Paciente paciente { get; set; }
        private Secretaria secretaria { get; set; }
        private Enfermera enfermeraChequeo { get; set; }
        private Medico medicoTratante { get; set; }
        public  { get; set; }
        private float peso { get; set; }//kg
        private int estatura { get; set; }//cm
        private float imc { get; set; }// indice de masa corporal

        private float temperatura { get; set; } //°C

        private int sistonica { get; set; } //mmHg  SYS
        private int diastolica { get; set; } //     DIA
        private int pulsacion { get; set; }//min    PUL/min


        private String diagnostico;

        public FichaPaciente()
        {
            Init();
        }

        private void Init()
        {
            idfichaMedica = 0;
            fechaIngreso = DateTime.Now;
            paciente = null;
            secretaria = null;
            enfermeraChequeo = null;
            medicoTratante = null;
            peso = 0;
            estatura = 0;
            imc = 0;
            temperatura = 0;
            sistonica = 0;
            diastolica = 0;
            pulsacion = 0;

            diagnostico = String.Empty;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // sb.AppendFormat("Medico: rut Medico : {0}-{1} /n Especialidad : {2}", rutMedico, dvMedico, especialidad);
            sb.AppendLine("Ficha Medica");
            sb.AppendFormat("Numero de ficha: {0}  , Fecha Ingreso : {1} , Paciente : {2} , Secretaria {3} , Enfermera: {4} ", idfichaMedica, fechaIngreso, paciente, secretaria, enfermeraChequeo);
            sb.AppendFormat("Medico Tratante: {0} , peso {1} estatura {2} temperatura {3} , sistonica {4} , diastolica {5} pulsacion {6} , Diagnostico {7}", medicoTratante, peso, estatura, temperatura, sistonica, diastolica, pulsacion, diagnostico);
            return sb.ToString();
        }
    }
}
