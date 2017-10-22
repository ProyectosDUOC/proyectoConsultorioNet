using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;

namespace Biblioteca.Clases
{
    public class Consultorio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int rut;

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private Comuna comuna;

        public Comuna Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public Consultorio()
        {
            Init();
        }
        private void Init()
        {
            id = 0;
            rut = 0;
            dv = '0';
            comuna = null;
            nombre = String.Empty;
        }

        public bool Create() {
            try
            {
                Consultiorios.DALC.Consultorio consultorio = new Consultiorios.DALC.Consultorio();

                consultorio.id_consultorio = this.Id;
                consultorio.rut_consultorio = this.Rut;
                consultorio.dv = this.Dv.ToString();
                consultorio.id_comuna = this.Comuna.Id;
                consultorio.nombre = this.Nombre;

                CommonBC.ModeloConsultorio.AddToConsultorio(consultorio);
                CommonBC.ModeloConsultorio.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read(){
            try
            {
                Consultiorios.DALC.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );
                this.Id = consultorio.id_consultorio;
                this.Rut = consultorio.id_consultorio;
                this.Dv = Char.Parse(consultorio.dv);
                this.Comuna.Id = consultorio.id_comuna;
                this.Nombre = consultorio.nombre;
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
                Consultiorios.DALC.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );

                consultorio.id_consultorio = this.Id;
                consultorio.rut_consultorio = this.Rut;
                consultorio.dv = this.Dv.ToString();
                consultorio.id_comuna = this.Comuna.Id;
                consultorio.nombre = this.Nombre;
               
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
                Consultiorios.DALC.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );
                CommonBC.ModeloConsultorio.DeleteObject(consultorio);
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
