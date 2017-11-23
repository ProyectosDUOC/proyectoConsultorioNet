using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class FichaPaciente
    {
        private int id_ficha_paciente;

        public int Id_ficha_paciente
        {
            get { return id_ficha_paciente; }
            set { id_ficha_paciente = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int idConsultorio;

        public int IdConsultorio
        {
            get { return idConsultorio; }
            set { idConsultorio = value; }
        }


        private int idSecretaria;

        public int IdSecretaria
        {
            get { return idSecretaria; }
            set { idSecretaria = value; }
        }


        private int idMedico;

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }


        private int idEnfermera;

        public int IdEnfermera
        {
            get { return idEnfermera; }
            set { idEnfermera = value; }
        }


        private int idPaciente;

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

       
        private int peso;

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private int estatura;

        public int Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
        private int imc;

        public int Imc
        {
            get { return imc; }
            set { imc = value; }
        }
        private int temperatura;

        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
        private int sistonica;

        public int Sistonica
        {
            get { return sistonica; }
            set { sistonica = value; }
        }
        private int distolica;

        public int Distolica
        {
            get { return distolica; }
            set { distolica = value; }
        }
        private int pulsacion;

        public int Pulsacion
        {
            get { return pulsacion; }
            set { pulsacion = value; }
        }
        private int diastolica;

        public int Diastolica
        {
            get { return diastolica; }
            set { diastolica = value; }
        }

        private String motivo;

        public String Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }

        private String diagnostico;

        public String Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }
       public FichaPaciente() {
           Init();
       }

       private void Init() {
           id_ficha_paciente = 0;
           fecha = DateTime.Now;
           idConsultorio = 0;
           idSecretaria = 0;
           idMedico = 0;
           idEnfermera = 0;
           idPaciente = 0;
           peso = 0;
           estatura = 0;
           imc = 0;
           temperatura = 0;
           sistonica = 0;
           distolica = 0;
           pulsacion = 0;
           diastolica = 0;
           motivo = " ";
           diagnostico = " ";

       }

       public override string ToString()
       {
           return base.ToString();
       }
       public bool Create() {
           try
           {
               capaDatos.Ficha_Paciente fichaPac = new capaDatos.Ficha_Paciente();

               fichaPac.id_ficha_paciente = this.id_ficha_paciente;
               fichaPac.fecha = DateTime.Now;
               fichaPac.id_consultorio = 1; // por defecto es 1 
               fichaPac.id_Medico = 0;
               fichaPac.id_enfermera = 0;
               fichaPac.id_paciente = this.idPaciente;
               fichaPac.peso = 0;
               fichaPac.estatura = 0;
               fichaPac.imc = 0;
               fichaPac.temperatura = 0;
               fichaPac.sistonica = 0;
               fichaPac.distolica = 0;
               fichaPac.pulsacion = 0;
               fichaPac.diastolica = 0;
               fichaPac.motivos = this.motivo;
               fichaPac.diagnostico = " ";

               CommonBC.ModeloConsultorio.AddToFicha_Paciente(fichaPac);
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
               capaDatos.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
                   (
                    fic => fic.id_ficha_paciente == this.Id_ficha_paciente
                   );             
               this.Fecha = (DateTime)fichaPac.fecha;
               this.idConsultorio = (int)fichaPac.id_consultorio;
               this.idMedico = (int)fichaPac.id_Medico;
               this.idEnfermera = (int)fichaPac.id_enfermera;
               this.idPaciente = (int)fichaPac.id_paciente;
               this.Peso = (int)fichaPac.peso;
               this.Estatura = (int)fichaPac.estatura;
               this.Imc = (int)fichaPac.imc;
               this.Temperatura = (int)fichaPac.temperatura;
               this.Sistonica = (int)fichaPac.sistonica;
               this.Distolica = (int)fichaPac.distolica;
               this.Pulsacion = (int)fichaPac.pulsacion;
               this.Diastolica = (int)fichaPac.diastolica;
               this.diagnostico = fichaPac.diagnostico;
               this.motivo = fichaPac.motivos;
               
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
               capaDatos.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
                   (
                    fic => fic.id_ficha_paciente == this.Id_ficha_paciente
                   );

               fichaPac.id_Medico = this.idMedico;
               fichaPac.id_enfermera = this.idEnfermera;
               fichaPac.peso = this.peso;
               fichaPac.estatura = this.estatura;
               fichaPac.imc = this.imc;
               fichaPac.temperatura = this.temperatura;
               fichaPac.sistonica = this.sistonica;
               fichaPac.distolica = this.distolica;
               fichaPac.pulsacion = this.pulsacion;
               fichaPac.diastolica = this.diastolica;
               fichaPac.motivos = this.motivo;
               fichaPac.diagnostico = this.diagnostico;
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
               capaDatos.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
                   (
                    fic => fic.id_ficha_paciente == this.Id_ficha_paciente
                   );
               CommonBC.ModeloConsultorio.DeleteObject(fichaPac);
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
