using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class AlergiaPacienteColeccion
    {
        public List<AlergiaPaciente> GenerarListado(List<Consultiorios.DALC.Alergia_Paciente> AlergiaPacienteDALC)
        {
            List<Biblioteca.ClasesExterior.AlergiaPaciente> alergiaPacientes = new List<AlergiaPaciente>();

            foreach (Consultiorios.DALC.Alergia_Paciente alerPa in AlergiaPacienteDALC)
            {
                Biblioteca.ClasesExterior.AlergiaPaciente alergiaPaciente = new AlergiaPaciente();

                alergiaPaciente.Id = alerPa.id_alergia;
                alergiaPaciente.Alergia.Id = alerPa.id_alergia;
                alergiaPaciente.Paciente.Id = alerPa.Paciente.id_paciente;

                alergiaPacientes.Add(alergiaPaciente);
            } 
            return alergiaPacientes;
        }

        //Listado de todos los elementos

        public List<AlergiaPaciente> ReadAll()
        {
            var alergiaPacientes = CommonBC.ModeloConsultorio.Alergia_Paciente;
            return GenerarListado(alergiaPacientes.ToList());
        }
    
    }
}
