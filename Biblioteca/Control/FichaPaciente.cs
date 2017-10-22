using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;
using Biblioteca.ClasesExterior;


namespace Biblioteca.Control
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
        private Consultorio consultorio;

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }
        private Secretaria secretaria;

        public Secretaria Secretaria
        {
            get { return secretaria; }
            set { secretaria = value; }
        }
        private Medico medico;

        public Medico Medico
        {
            get { return medico; }
            set { medico = value; }
        }
        private Enfermera enfermera;

        public Enfermera Enfermera
        {
            get { return enfermera; }
            set { enfermera = value; }
        }
        private Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
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

       public FichaPaciente() {
           Init();
       }

       private void Init() {
           id_ficha_paciente = 0;
           fecha = DateTime.Now;
           consultorio = null;
           secretaria = null;
           medico = null;
           enfermera = null;
           paciente = null;
           peso = 0;
           estatura = 0;
           imc = 0;
           temperatura = 0;
           sistonica = 0;
           distolica = 0;
           pulsacion = 0;
           diastolica = 0;

       }

       public bool Create() {
           try
           {
               Consultiorios.DALC.Ficha_Paciente fichaPac = new Consultiorios.DALC.Ficha_Paciente();
               fichaPac.id_ficha_paciente = this.Id_ficha_paciente;
               fichaPac.fecha = this.Fecha;
               fichaPac.id_consultorio = this.Consultorio.Id;
               fichaPac.id_secretaria = this.Secretaria.Id;
               fichaPac.id_Medico = this.Medico.Id;
               fichaPac.id_enfermera = this.Enfermera.Id;
               fichaPac.id_paciente = this.Paciente.Id;
               fichaPac.peso = this.Peso;
               fichaPac.estatura = this.Estatura;
               fichaPac.imc = this.Imc;
               fichaPac.temperatura = this.Temperatura;
               fichaPac.sistonica = this.Sistonica;
               fichaPac.distolica = this.Distolica;
               fichaPac.pulsacion = this.Pulsacion;
               fichaPac.diastolica = this.Diastolica;

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
               Consultiorios.DALC.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
                   (
                    fic => fic.id_ficha_paciente == this.Id_ficha_paciente
                   );             
               this.Fecha = (DateTime)fichaPac.fecha;
               this.Consultorio.Id = fichaPac.id_consultorio;
               this.Secretaria.Id = fichaPac.id_secretaria;
               this.Medico.Id = fichaPac.id_Medico;
               this.Enfermera.Id = fichaPac.id_enfermera ;
               this.Paciente.Id = fichaPac.id_paciente;
               this.Peso = fichaPac.peso;
               this.Estatura = fichaPac.estatura;
               this.Imc = fichaPac.imc;
               this.Temperatura = fichaPac.temperatura;
               this.Sistonica = fichaPac.sistonica;
               this.Distolica = fichaPac.distolica;
               this.Pulsacion = fichaPac.pulsacion;
               this.Diastolica = fichaPac.diastolica;
               
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
               Consultiorios.DALC.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
                   (
                    fic => fic.id_ficha_paciente == this.Id_ficha_paciente
                   );             
               fichaPac.fecha = this.Fecha;
               fichaPac.id_consultorio = this.Consultorio.Id;
               fichaPac.id_secretaria = this.Secretaria.Id;
               fichaPac.id_Medico = this.Medico.Id;
               fichaPac.id_enfermera = this.Enfermera.Id;
               fichaPac.id_paciente = this.Paciente.Id;
               fichaPac.peso = this.Peso;
               fichaPac.estatura = this.Estatura;
               fichaPac.imc = this.Imc;
               fichaPac.temperatura = this.Temperatura;
               fichaPac.sistonica = this.Sistonica;
               fichaPac.distolica = this.Distolica;
               fichaPac.pulsacion = this.Pulsacion;
               fichaPac.diastolica = this.Diastolica;
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
               Consultiorios.DALC.Ficha_Paciente fichaPac = CommonBC.ModeloConsultorio.Ficha_Paciente.First
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
