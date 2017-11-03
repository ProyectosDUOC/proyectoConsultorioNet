using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.ClasesExterior
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

        private Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        } 

        public AlergiaPaciente()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            idAlergia = 0;
            paciente = null;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Alergia_Paciente alergiaPac = new Consultiorios.DALC.Alergia_Paciente();

                
                alergiaPac.id_alergia_paciente = this.Id;
                alergiaPac.id_alergia = this.IdAlergia;
                alergiaPac.id_paciente = this.Paciente.Id;

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
                Consultiorios.DALC.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
                    (
                        alergiaPaciente => alergiaPaciente.id_alergia_paciente == this.Id
                    );             
                this.Paciente.Id = alergiaPac.id_paciente;
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
                Consultiorios.DALC.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
                    (
                        alergiaPaciente => alergiaPaciente.id_alergia_paciente == this.Id
                    );              
                 alergiaPac.id_paciente = this.Paciente.Id;
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
                Consultiorios.DALC.Alergia_Paciente alergiaPac = CommonBC.ModeloConsultorio.Alergia_Paciente.First
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
