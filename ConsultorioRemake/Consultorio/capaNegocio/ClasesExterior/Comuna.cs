using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
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

        private int idProvincia;

        public int IdProvincia
        {
            get { return idProvincia; }
            set { idProvincia = value; }
        }

       

        public Comuna() {
            Init();
        }

        private void Init() {
            id = 0;
            nombre = String.Empty;
            idProvincia = 0;
        }

        public bool Create() 
        {
            try
            {
                capaDatos.Comuna comuna = new capaDatos.Comuna();

                comuna.id_comuna = this.Id;
                comuna.nom_com = this.Nombre;
                comuna.id_provincia = this.idProvincia;

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
                capaDatos.Comuna comuna =
                    CommonBC.ModeloConsultorio.Comuna.First
                        (
                            comun => comun.id_comuna == this.Id
                        );

                this.Nombre = comuna.nom_com;
                this.IdProvincia = comuna.id_provincia;

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
                capaDatos.Comuna comuna =
                    CommonBC.ModeloConsultorio.Comuna.First
                        (
                            comun => comun.id_comuna == this.Id
                        );

                comuna.nom_com = this.Nombre;
                comuna.id_provincia = this.IdProvincia;

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
                capaDatos.Comuna comuna =
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
