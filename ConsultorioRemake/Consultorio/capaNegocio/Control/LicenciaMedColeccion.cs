using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;

namespace capaNegocio
{
    public class LicenciaMedColeccion
    {
        private static List<LicenciaMedica> GenerarListado(List<capaDatos.Licencia_Medica> licenciaMedicaDALC) 
        {
            List<capaNegocio.LicenciaMedica> licenciasMedicas = new List<LicenciaMedica>();
            foreach (capaDatos.Licencia_Medica lm in licenciaMedicaDALC)
            {
                capaNegocio.LicenciaMedica licenciasMe = new LicenciaMedica();

                licenciasMe.IdLicencia = lm.id_licencia_medica;
                licenciasMe.Motivo = lm.motivos;
                licenciasMe.NumeroDias = (int)lm.numero_de_dias;
                licenciasMe.IdPaciente = (int)lm.id_ficha_paciente;

                licenciasMedicas.Add(licenciasMe);
            }


            return licenciasMedicas;
        }

        public List<LicenciaMedica> ReadAll()
        {
            var licenciaM = CommonBC.ModeloConsultorio.Licencia_Medica;
            return GenerarListado(licenciaM.ToList());
        }

    }
}
