using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Sector
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

        public Sector() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
        }


        public bool Create()
        {
            try
            {
                capaDatos.Sector sector = new capaDatos.Sector();

                sector.id_sector = this.Id;
                sector.nombre = this.Nombre;

                CommonBC.ModeloConsultorio.AddToSector(sector);
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
                capaDatos.Sector sec = CommonBC.ModeloConsultorio.Sector.First(
                                                    s => s.id_sector == this.Id);

                this.Nombre = sec.nombre;

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
                capaDatos.Sector sec = CommonBC.ModeloConsultorio.Sector.First(
                                                    s => s.id_sector == this.Id);
                sec.nombre = this.Nombre;

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
                capaDatos.Sector sec = CommonBC.ModeloConsultorio.Sector.First(
                                                    s => s.id_sector == this.Id);
                CommonBC.ModeloConsultorio.DeleteObject(sec);
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
