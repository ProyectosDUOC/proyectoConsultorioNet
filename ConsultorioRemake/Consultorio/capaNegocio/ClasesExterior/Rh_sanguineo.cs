using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Rh_sanguineo
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

        public Rh_sanguineo() {
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
                capaDatos.Rh_sanguineo rhs = new capaDatos.Rh_sanguineo();
                rhs.id_rh = this.Id;
                rhs.nombre = this.Nombre;


                CommonBC.ModeloConsultorio.AddToRh_sanguineo(rhs);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        public bool Read()
        {
            try
            {
                capaDatos.Rh_sanguineo rhs = CommonBC.ModeloConsultorio.Rh_sanguineo.First(
                                                            r => r.id_rh == this.Id);
                this.Nombre = rhs.nombre;

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
                capaDatos.Rh_sanguineo rhs = CommonBC.ModeloConsultorio.Rh_sanguineo.First(
                                                                r => r.id_rh == this.Id);

                rhs.nombre = this.Nombre;

                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                capaDatos.Rh_sanguineo rhs = CommonBC.ModeloConsultorio.Rh_sanguineo.First(
                                                                r => r.id_rh == this.Id);

                CommonBC.ModeloConsultorio.DeleteObject(rhs);
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
