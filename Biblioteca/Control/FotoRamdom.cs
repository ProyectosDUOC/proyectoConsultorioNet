using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Control
{
    public class FotoRamdom
    {


        //private uint id; //por defecto    

        //private String user;
        //private String contrasena;

        //private int rut; //validad rut
        //private char dv;  //digito verificador
        //private String foto; //ruta de la foto guardada

        //private String pnombre;
        //private String snombre;
        //private String appaterno;
        //private String apmaterno;


        //private DateTime fechaNacimiento;
        //private Genero genero;

        //private Nacionalidad nacionalidad;
        //private Comuna comuna;
        //private String direccion;
        //private String fono1;
        //private String fono2;

        public static Usuario elegirUsuario() {
            Usuario user = new Usuario();
            Random rnd = new Random();

            int nro = rnd.Next(0,5);

            if (nro == 0){
                user = new Usuario(1, 11111111, '1', "foto1.jpg", "benjamin");             
            }
            if (nro == 1) {
                user = new Usuario(2, 11111111, '1', "foto2.jpg", "Sebatian");
            }
            if (nro == 2)
            {
                user = new Usuario(3, 11111111, '1', "foto3.jpg", "Patricia");
            }
            if (nro == 4)
            {
                user = new Usuario(4, 11111111, '1', "foto4.jpg", "Carlos");
            }

            return user;
        } 

    }
}
