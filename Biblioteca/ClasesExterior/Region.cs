using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
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

        private Pais pais;

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public Region() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            Pais = null;
        }

        public bool Create()
        {
            try
            {
                Consultiorios.DALC.Region reg = new Consultiorios.DALC.Region();

                reg.id_pais = this.Pais.Id;
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
                Consultiorios.DALC.Region reg = CommonBC.ModeloConsultorio.Region.First(
                                                    r => r.id_region == this.Id);

                this.Nombre = reg.nom_region;
                this.Pais.Id = reg.id_pais;

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
                Consultiorios.DALC.Region reg = CommonBC.ModeloConsultorio.Region.First(
                                                    r => r.id_region == this.Id);
                reg.id_pais = this.Pais.Id;
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
                Consultiorios.DALC.Region reg = CommonBC.ModeloConsultorio.Region.First(
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
