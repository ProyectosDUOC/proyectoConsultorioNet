using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Consultiorios.DALC;
using Biblioteca.Clases;

namespace Biblioteca.Control
{
    public class LicenciaMedColeccion
    {
        private static List<LicenciaMedica> GenerarListado(List<Consultiorios.DALC.Licencia_Medica> licenciaMedicaDALC) 
        {
            List<Biblioteca.Control.LicenciaMedica> licenciasMedicas = new List<LicenciaMedica>();
            foreach (Consultiorios.DALC.Licencia_Medica lm in licenciaMedicaDALC)
            {
                Biblioteca.Control.LicenciaMedica licenciasMe = new LicenciaMedica();

                licenciasMe.IdLicencia = lm.id_licencia_medica;
                licenciasMe.Motivo = lm.motivos;
                licenciasMe.NumeroDias = lm.numero_de_dias;
                licenciasMe.IdPaciente = lm.id_ficha_paciente;

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
