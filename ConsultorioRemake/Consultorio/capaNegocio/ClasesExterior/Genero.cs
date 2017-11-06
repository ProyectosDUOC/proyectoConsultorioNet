using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Genero
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

        public Genero() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
        }

        public bool Create() {
            try
            {
                capaDatos.Genero genero = new capaDatos.Genero();

                genero.id_genero = this.Id;
                genero.nom_genero = this.Nombre;

                CommonBC.ModeloConsultorio.AddToGenero(genero);
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
                capaDatos.Genero genero = CommonBC.ModeloConsultorio.Genero.First
                    (
                        gen => gen.id_genero == this.Id                 
                    );
              
                this.Nombre = genero.nom_genero;            
               
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
                capaDatos.Genero genero = CommonBC.ModeloConsultorio.Genero.First
                    (
                        gen => gen.id_genero == this.Id
                    );          

              
                genero.nom_genero = this.Nombre;

              
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
                capaDatos.Genero genero = CommonBC.ModeloConsultorio.Genero.First
                    (
                        gen => gen.id_genero == this.Id
                    );
                CommonBC.ModeloConsultorio.DeleteObject(genero);
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
