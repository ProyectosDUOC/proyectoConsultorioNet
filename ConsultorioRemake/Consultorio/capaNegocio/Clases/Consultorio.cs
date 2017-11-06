using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
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
        private int idComuna;

        public int IdComuna
        {
            get { return idComuna; }
            set { idComuna = value; }
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
            idComuna = 0;
            nombre = String.Empty;
        }

        public bool Create() {
            try
            {
                capaDatos.Consultorio consultorio = new capaDatos.Consultorio();

                consultorio.id_consultorio = this.Id;
                consultorio.rut_consultorio = this.Rut;
                consultorio.dv = this.Dv.ToString();
                consultorio.id_comuna = this.idComuna;
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
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );              
                this.Rut = consultorio.id_consultorio;
                this.Dv = Char.Parse(consultorio.dv);
                this.IdComuna = consultorio.id_comuna;
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
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
                            (
                                    consulto => consulto.id_consultorio == this.Id
                                );                
                consultorio.rut_consultorio = this.Rut;
                consultorio.dv = this.Dv.ToString();
                consultorio.id_comuna = this.IdComuna;
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
                capaDatos.Consultorio consultorio = CommonBC.ModeloConsultorio.Consultorio.First
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
