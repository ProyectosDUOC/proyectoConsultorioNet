using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class LicenciaMedica
    {
        private int idLicencia;
        private int numeroDias;
        private string motivo;
        private int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public LicenciaMedica() 
        {
            Init();
        }

        public int IdLicencia
        {
            get { return idLicencia; }
            set { idLicencia = value; }
        }
      
        public int NumeroDias
        {
            get { return numeroDias; }
            set { numeroDias = value; }
        }
        
        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        private void Init()
        {
            idLicencia = 0; 
            idPaciente = 0;
            numeroDias = 0;
            motivo = String.Empty;

        }     

        public bool Create() {
            try
            {
                capaDatos.Licencia_Medica licenciaMe = new capaDatos.Licencia_Medica();
                licenciaMe.id_licencia_medica = this.IdLicencia;
                licenciaMe.numero_de_dias = this.NumeroDias;
                licenciaMe.motivos = this.Motivo;
                licenciaMe.id_ficha_paciente = this.idPaciente;
                CommonBC.ModeloConsultorio.AddToLicencia_Medica(licenciaMe);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read() {
            try
            {
                capaDatos.Licencia_Medica licenciaMe = CommonBC.ModeloConsultorio.Licencia_Medica.First
                    (
                        licencia => licencia.id_licencia_medica == this.IdLicencia
                    );

                this.NumeroDias = licenciaMe.numero_de_dias;
                this.Motivo = licenciaMe.motivos;
                this.idPaciente = licenciaMe.id_ficha_paciente;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                capaDatos.Licencia_Medica licenciaMe = CommonBC.ModeloConsultorio.Licencia_Medica.First
                    (
                        licencia => licencia.id_licencia_medica == this.IdLicencia
                    );

                licenciaMe.numero_de_dias = this.NumeroDias;
                licenciaMe.motivos = this.Motivo;
                licenciaMe.id_ficha_paciente = this.idPaciente;

                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                capaDatos.Licencia_Medica licenciaMe = CommonBC.ModeloConsultorio.Licencia_Medica.First
                    (
                        licencia => licencia.id_licencia_medica == this.IdLicencia
                    );

                CommonBC.ModeloConsultorio.DeleteObject(licenciaMe);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
