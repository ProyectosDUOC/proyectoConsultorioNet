using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.ClasesExterior;
using Biblioteca.Control;
using Biblioteca.Clases;

namespace Biblioteca
{
    public class Usuario
    {
        private int id; //por defecto    

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int rut; //validad rut

        public int Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        private char dv;  //digito verificador

        public char Dv
        {
            get { return dv; }
            set { dv = value; }
        }
        private String foto; //ruta de la foto guardada

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private String pnombre;

        public String Pnombre
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
        private String snombre;

        public String Snombre
        {
            get { return snombre; }
            set { snombre = value; }
        }
        private String appaterno;

        public String Appaterno
        {
            get { return appaterno; }
            set { appaterno = value; }
        }
        private String apmaterno;

        public String Apmaterno
        {
            get { return apmaterno; }
            set { apmaterno = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private String fono1;

        public String Fono1
        {
            get { return fono1; }
            set { fono1 = value; }
        }
        private String fono2;

        public String Fono2
        {
            get { return fono2; }
            set { fono2 = value; }
        }
        private Comuna comuna;

        public Comuna Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        private Nacionalidad nacionalidad;

        public Nacionalidad Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        private Genero genero;

        public Genero Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        private int activo;

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    
        public Usuario() 
        {
            Init();        
        }
        
        private void Init() 
        {
            id = 0;            
            rut = 0;
            dv = '0';
            foto = "0000";
            pnombre = String.Empty;
            snombre = String.Empty;
            appaterno = String.Empty;
            apmaterno = String.Empty;
            fechaNacimiento = DateTime.Now;
            genero = null;
            nacionalidad = null;
            comuna = null;
            direccion = String.Empty;
            fono1 = String.Empty;
            fono2 = String.Empty;
            activo = 0;
        }




        /*  public override string ToString()
          {
              StringBuilder sb = new StringBuilder();
              sb.AppendFormat("User: {0} : pass {1} \n", controlAcceso.usuario.ToString(), controlAcceso.pass.ToString());
              sb.AppendFormat("Rut = {0}-{1} \n Nombre Completo: {2} {3} {4} {5} \n foto : {6} \n Fecha de Nacimiento: {7} \n Sexo: {8}", rut, dv, pnombre, snombre, appaterno, apmaterno, foto, fechaNacimiento, genero);
              sb.AppendFormat("\n Nacionalidad: {0} \n Comuna: {1} \n Direccion: {2} \n Fono 1: {3} \n Fono 2: {4} ", nacionalidad, comuna, direccion, fono1, fono2);
              sb.AppendFormat("ACtivo {0}", activo);
              return sb.ToString();
          }

           public bool Create()
          {
              try
              {
                  Consultiorios.DALC.Usuario usuario = new Consultiorios.DALC.Usuario();

                  usuario.id_usuario = this.Id;
                  usuario.rut_usuario = this.Rut;
                  usuario.dv_usuario = this.Dv.ToString();
                  usuario.foto = this.Foto;
                  usuario.pnombre = this.Pnombre;
                  usuario.snombre = this.Snombre;
                  usuario.appaterno = this.Appaterno;
                  usuario.apmaterno = this.Apmaterno;
                  usuario.fecha_nacimiento = this.FechaNacimiento;
              

       
              
               

                //  CommonBC.ModeloBibliotecas.AddToBiblioteca(bib);
                //  CommonBC.ModeloBibliotecas.SaveChanges();
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
                  Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First
                      (
                          bib => bib.Id == this.Id
                      );
                  this.nombre = biblioteca.Nombre;
                  this.publica = biblioteca.Publica;
                  this.inaguracion = biblioteca.Inauguracion;
                  this.libros = biblioteca.Libros;
                  return true;
              }
              catch (Exception ex)
              {

                  return false;
              }

          }

          public bool update()
          {
              try
              {
                  Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First
                      (
                            bib => bib.Id == this.Id
                      );
                  this.nombre = biblioteca.Nombre;
                  this.publica = biblioteca.Publica;
                  this.inaguracion = biblioteca.Inauguracion;
                  this.libros = biblioteca.Libros;

                  CommonBC.ModeloBibliotecas.SaveChanges();
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
                  Bibliotecas.DALC.Biblioteca biblioteca = CommonBC.ModeloBibliotecas.Biblioteca.First
                      (
                          bib => bib.Id == this.Id

                      );
                  CommonBC.ModeloBibliotecas.DeleteObject(biblioteca);
                  CommonBC.ModeloBibliotecas.SaveChanges();
                  return true;
              }
              catch (Exception ex)
              {
                  return false;
                  throw;
              }

          }

      }*/
    }
}
