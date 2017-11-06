using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class Region
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

        private int idPais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        public Region() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            IdPais = 0;
        }

        public bool Create()
        {
            try
            {
                capaDatos.Region reg = new capaDatos.Region();

                reg.id_pais = this.IdPais;
                reg.id_region = this.Id;
                reg.nom_region = this.Nombre;

                CommonBC.ModeloConsultorio.AddToRegion(reg);
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
                capaDatos.Region reg = CommonBC.ModeloConsultorio.Region.First(
                                                    r => r.id_region == this.Id);

                this.Nombre = reg.nom_region;
                this.IdPais = reg.id_pais;

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
                capaDatos.Region reg = CommonBC.ModeloConsultorio.Region.First(
                                                    r => r.id_region == this.Id);
                reg.id_pais = this.IdPais;
                reg.nom_region = this.Nombre;

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
                capaDatos.Region reg = CommonBC.ModeloConsultorio.Region.First(
                                    r => r.id_region == this.Id);

                CommonBC.ModeloConsultorio.DeleteObject(reg);
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
