using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Comuna
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

        private Provincia provincia;

        public Provincia Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public Comuna() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            provincia = null;
        }

        public bool Create() 
        {
            try
            {
                Consultiorios.DALC.Comuna comuna = new Consultiorios.DALC.Comuna();

                comuna.id_comuna = this.Id;
                comuna.nom_com = this.Nombre;
                comuna.id_provincia = this.provincia.Id;

                CommonBC.ModeloConsultorio.AddToComuna(comuna);
                CommonBC.ModeloConsultorio.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public bool Read()
        {
            try
            {
                Consultiorios.DALC.Comuna comuna =
                    CommonBC.ModeloConsultorio.Comuna.First
                        (
                            comun => comun.id_comuna == this.Id
                        );

                this.Nombre = comuna.nom_com;
                this.provincia.Id = comuna.id_provincia;

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
                Consultiorios.DALC.Comuna comuna =
                    CommonBC.ModeloConsultorio.Comuna.First
                        (
                            comun => comun.id_comuna == this.Id
                        );

                comuna.nom_com = this.Nombre;
                comuna.id_provincia = this.Provincia.Id;

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
                Consultiorios.DALC.Comuna comuna =
                    CommonBC.ModeloConsultorio.Comuna.First
                        (
                            comun => comun.id_comuna == this.Id
                        );

                CommonBC.ModeloConsultorio.DeleteObject(comuna);
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
