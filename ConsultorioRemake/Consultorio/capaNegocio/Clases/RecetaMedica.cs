using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio.Clases
{
    public class RecetaMedica
    {
        private int idReceta;

        public int IdReceta
        {
            get { return idReceta; }
            set { idReceta = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int cant;

        public int Cant
        {
            get { return cant; }
            set { cant = value; }
        }
        private int hora;

        public int Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        private int dia;

        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }
        private int idFicha;

        public int IdFicha
        {
            get { return idFicha; }
            set { idFicha = value; }
        }
        private int idMedicamento;

        public int IdMedicamento
        {
            get { return idMedicamento; }
            set { idMedicamento = value; }
        }
        public RecetaMedica() {
            init();
        
        }

        private void init() {         
            IdReceta=0;
            Fecha = DateTime.Now;
            Cant = 0;
            Hora = 0;
            Dia = 0;
            Glosa = "";
            IdFicha = 0;
            IdMedicamento = 0;
        }

        public bool Create() {
            try
            {
                ConsultoriosEntities modelo = new ConsultoriosEntities();
                capaDatos.Receta_Medica recete = new capaDatos.Receta_Medica();
                recete.id_ficha_paciente = this.idFicha;
                recete.fecha = DateTime.Now;
                recete.cantidad = this.cant;
                recete.hora = this.hora;
                recete.dia = this.dia;
                recete.glosa = this.glosa;
                recete.id_Receta_Medica = this.idReceta;
                recete.id_medicamentos = this.IdMedicamento;

                modelo.AddToReceta_Medica(recete);
                modelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }   
        }
        public bool ReadFicha() {
            try
            {
                ConsultoriosEntities modelo = new ConsultoriosEntities();
                capaDatos.Receta_Medica recete = modelo.Receta_Medica.First(
                        rec => rec.id_ficha_paciente == this.idFicha
                    
                    );
                recete.id_ficha_paciente = this.idFicha;
                recete.id_medicamentos = this.idMedicamento;
                recete.id_Receta_Medica = this.idReceta;
                recete.fecha = this.fecha;
                recete.cantidad = this.cant;
                recete.hora = this.hora;
                recete.dia = this.dia;
                recete.glosa = this.glosa;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        
         }
        public bool ReadIDReceta()
        {
            try
            {
                ConsultoriosEntities modelo = new ConsultoriosEntities();
                capaDatos.Receta_Medica recete = modelo.Receta_Medica.First(
                        rec => rec.id_Receta_Medica == this.idReceta

                    );
                recete.id_ficha_paciente = this.idFicha;
                recete.id_medicamentos = this.idMedicamento;
                recete.id_Receta_Medica = this.idReceta;
                recete.fecha = this.fecha;
                recete.cantidad = this.cant;
                recete.hora = this.hora;
                recete.dia = this.dia;
                recete.glosa = this.glosa;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
