using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Especialidad
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Especialidad()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            nombre = String.Empty;
        }
        public bool Create() {
            try
            {
                Consultiorios.DALC.Especialidad especialidad = new Consultiorios.DALC.Especialidad();
                especialidad.id_especialidad = this.Id;
                especialidad.nom_especialidad = this.Nombre;

                CommonBC.ModeloConsultorio.AddToEspecialidad(especialidad);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {                
                return false;
            }            
        }
        public bool Read(){
            try
            {
                Consultiorios.DALC.Especialidad especialidad = CommonBC.ModeloConsultorio.Especialidad.First
                    (
                        especial => especial.id_especialidad == this.Id
                    );
             
                this.Nombre = especialidad.nom_especialidad;

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
                Consultiorios.DALC.Especialidad especialidad = CommonBC.ModeloConsultorio.Especialidad.First
                    (
                        especial => especial.id_especialidad == this.Id
                    );

            
                this.Nombre = especialidad.nom_especialidad;
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete() {
            try
            {
                
                Consultiorios.DALC.Especialidad especialidad = CommonBC.ModeloConsultorio.Especialidad.First
                    (
                        especial => especial.id_especialidad == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(especialidad);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }


    }
}
