using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;
using Biblioteca;

namespace Biblioteca.ClasesExterior
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
                Consultiorios.DALC.Alergia alergia = new Consultiorios.DALC.Alergia();

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
                Consultiorios.DALC.Alergia alergia =
                    CommonBC.ModeloConsultorio.Alergia.First
                        (
                            ale => ale.id_alergia == this.Id
                        );


                this.Id = alergia.id_alergia;
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
                Consultiorios.DALC.Alergia alergia =
                    CommonBC.ModeloConsultorio.Alergia.First
                        (
                            ale => ale.id_alergia == this.Id
                        );


                this.Id = alergia.id_alergia;
                this.Nombre = alergia.nombre;

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
