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
        private Alergia alergia;

        public Alergia Alergia
        {
            get { return alergia; }
            set { alergia = value; }
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
            alergia = null;
            paciente = null;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Alergia_Paciente alergiaPac = new Consultiorios.DALC.Alergia_Paciente();

                alergiaPac.id_alergia = this.Id;
                alergiaPac.id_alergia_paciente = this.Id;
                alergiaPac.id_paciente = this.Id;

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
                this.Id = alergiaPac.id_alergia;
<<<<<<< HEAD
           //  this.Paciente = alergiaPac.Paciente.id_paciente;
              //  this.alergia = alergiaPac.Alergia();
=======
                this.Paciente.Id = alergiaPac.id_paciente;
                this.Alergia.Id = alergiaPac.id_alergia;
>>>>>>> 4a8d6515988926c59a34711eb3cb551bdf22aa94
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
                 alergiaPac.id_alergia = this.Id;
                 alergiaPac.id_paciente = this.Paciente.Id;
                 alergiaPac.id_alergia = this.Alergia.Id;

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
