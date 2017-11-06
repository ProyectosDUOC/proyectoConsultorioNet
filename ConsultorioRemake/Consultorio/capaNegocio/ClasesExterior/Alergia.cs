using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Alergia
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
        public Alergia()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            nombre = String.Empty;
        }

        public bool Create() 
        {
            try 
            {
                capaDatos.Alergia alergia = new capaDatos.Alergia();

                alergia.id_alergia = this.Id;
                alergia.nombre = this.nombre;

                CommonBC.ModeloConsultorio.AddToAlergia(alergia);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                capaDatos.Alergia alergia =
                    CommonBC.ModeloConsultorio.Alergia.First
                        (
                            ale => ale.id_alergia == this.Id
                        );                
                this.Nombre = alergia.nombre;

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
                capaDatos.Alergia alergia =
                    CommonBC.ModeloConsultorio.Alergia.First
                        (
                            ale => ale.id_alergia == this.Id
                        );
            
                this.Nombre = alergia.nombre;

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
                capaDatos.Alergia alergia =
                    CommonBC.ModeloConsultorio.Alergia.First
                        (
                            ale => ale.id_alergia == this.Id
                        );
                CommonBC.ModeloConsultorio.DeleteObject(alergia);
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
