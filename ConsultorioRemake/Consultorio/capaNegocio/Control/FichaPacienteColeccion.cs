using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class FichaPacienteColeccion
    {
        private static List<FichaPaciente> GenerarListado(List<capaDatos.Ficha_Paciente> fichaPacienteDALC) 
        {
            List<capaNegocio.FichaPaciente> fichasPacientes = new List<FichaPaciente>();
            foreach (capaDatos.Ficha_Paciente fp in fichaPacienteDALC)
            {
                capaNegocio.FichaPaciente ficha = new FichaPaciente();
                ficha.Id_ficha_paciente = fp.id_ficha_paciente;
                ficha.Fecha = (DateTime)fp.fecha;
                ficha.IdConsultorio = fp.Consultorio.id_consultorio;
                ficha.IdSecretaria = fp.Secretaria.id_secretaria;
                ficha.IdMedico = fp.Medico.id_Medico;
                ficha.IdEnfermera = fp.Enfermera.id_enfermera;
                ficha.IdPaciente = fp.Paciente.id_paciente;
                ficha.Peso = (int)fp.peso;
                ficha.Estatura = (int)fp.estatura;
                ficha.Imc = (int)fp.imc;
                ficha.Temperatura = (int)fp.temperatura;
                ficha.Sistonica = (int)fp.sistonica;
                ficha.Distolica = (int)fp.distolica;
                ficha.Pulsacion = (int)fp.pulsacion;
                ficha.Diastolica = (int)fp.diastolica;

                fichasPacientes.Add(ficha);
            }

            return fichasPacientes;
        }

        public List<FichaPaciente> ReadAll() {
            var fichaPaciente = CommonBC.ModeloConsultorio.Ficha_Paciente;
            return GenerarListado(fichaPaciente.ToList());
        }
    }
}
