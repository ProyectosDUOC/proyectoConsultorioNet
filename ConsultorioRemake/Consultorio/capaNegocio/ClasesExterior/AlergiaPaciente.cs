using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class AlergiaPaciente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int idAlergia;

        public int IdAlergia
        {
            get { return idAlergia; }
            set { idAlergia = value; }
        }

        private int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public AlergiaPaciente()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            idAlergia = 0;
            idPaciente = 0;
        }

        public bool Create() {
            try
            {
                capaDatos.Alergia_Paciente alergiaPac = new capaDatos.Alergia_Paciente();

                
                alergiaPac.id_alergia_paciente = this.Id;
                alergiaPac.id_alergia = this.IdAlergia;
                alergiaPac.id_paciente = this.IdPaciente;

                CommonBC.ModeloConsultorio.AddToAlergia_Paciente(alergiaPac);
                CommonBC.ModeloConsultorio.SaveChanges();              

                return true;
            }
            catch (Exception ex)
            {                 
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                capaDatos.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
                    (
                        alergiaPaciente => alergiaPaciente.id_alergia_paciente == this.Id
                    );             
                this.idPaciente = alergiaPac.id_paciente;
                this.IdAlergia = alergiaPac.id_alergia;

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
                capaDatos.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
                    (
                        alergiaPaciente => alergiaPaciente.id_alergia_paciente == this.Id
                    );              
                 alergiaPac.id_paciente = this.idPaciente;
                 alergiaPac.id_alergia = this.IdAlergia;

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
                capaDatos.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
                    (
                        alergiaPaciente => alergiaPaciente.id_alergia_paciente == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(alergiaPac);
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
