using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class AlergiaPacienteColeccion
    {
        public static List<AlergiaPaciente> GenerarListado(List<capaDatos.Alergia_Paciente> AlergiaPacienteDALC)
        {
            List<capaNegocio.AlergiaPaciente> alergiaPacientes = new List<AlergiaPaciente>();

            foreach (capaDatos.Alergia_Paciente alerPa in AlergiaPacienteDALC)
            {
                capaNegocio.AlergiaPaciente alergiaPaciente = new AlergiaPaciente();

                alergiaPaciente.Id = alerPa.id_alergia;
                alergiaPaciente.IdAlergia = alerPa.id_alergia;
                alergiaPaciente.IdPaciente = alerPa.Paciente.id_paciente;

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
