using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Provincia
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

        private Region region;

        public Region Region
        {
            get { return region; }
            set { region = value; }
        }

        public Provincia() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            region = null;
        }

        public bool Create()
        {
            try
            {
                Consultiorios.DALC.Provincia prov = new Consultiorios.DALC.Provincia();

                prov.id_provincia = this.Id;
                prov.nom_com = this.Nombre;
                prov.id_region = this.Region.Id;

                CommonBC.ModeloConsultorio.AddToProvincia(prov);
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
                Consultiorios.DALC.Provincia prov = CommonBC.ModeloConsultorio.Provincia.First(
                                                        p => p.id_provincia == this.Id);

                this.Nombre = prov.nom_com;
                this.Region.Id = prov.id_region;

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
                Consultiorios.DALC.Provincia prov = CommonBC.ModeloConsultorio.Provincia.First(
                                                        p => p.id_provincia == this.Id);

                prov.nom_com = this.Nombre;
                prov.id_region = this.Region.Id;

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
                Consultiorios.DALC.Provincia prov =
                    CommonBC.ModeloConsultorio.Provincia.First
                        (
                            p => p.id_provincia == this.Id
                        );

                CommonBC.ModeloConsultorio.DeleteObject(prov);
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
