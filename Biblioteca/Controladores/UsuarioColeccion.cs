using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Controladores
{
    public class UsuarioColeccion
    {

        //CRUd
        private static List<Usuario> usuarios = new List<Usuario>();

        public UsuarioColeccion() 
        {
         usuarios = new List<Usuario>();
        }
        // se deberia tener uno por cada tipo de persona 
        // problema o error : dado en el caso que si un medico, enfermera o doctor es paciente
        // generare un error al ingresarlo porque ya existe el rut

        public  Boolean agregar(Usuario persona) 
        {
            if (buscar(persona.Rut) == null)
            {
                usuarios.Add(persona);
                return true;
            }           
            return false;
        }

        public static Usuario buscar(int rut)
        {
            return null;
        }

        public List<Usuario> listar() 
        {

            return usuarios;
        }

        public Boolean modificar(Usuario persona) 
        {
            int x = 0;
            foreach (Usuario use in usuarios)
            {
                if (use.Rut.Equals(persona.Rut))
                {
                    usuarios.Insert(x, persona);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(String rut) 
        {
            int x = 0;
            foreach (Usuario use in usuarios)
            {
                if (use.Rut.Equals(rut))
                {
                    usuarios.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }

        public static Boolean verificarRut(int rut, char digito) {

            string dv = "";

            int auxRut = rut;
            int[] mRut = new int[8];
            int suma = 0;

            for (int i = 0; i < rut.ToString().Length; i++)
            {
                mRut[i] = (auxRut % 10);
                auxRut = (auxRut / 10);
            }
           
            if (rut.ToString().Length == 8)
            {
                suma = mRut[0] * 2 + mRut[1] * 3 + mRut[2] * 4 + mRut[3] * 5 + mRut[4] * 6 + mRut[5] * 7 + mRut[6] * 2 + mRut[7] * 3;
            }
            else
            {
                suma = mRut[0] * 2 + mRut[1] * 3 + mRut[2] * 4 + mRut[3] * 5 + mRut[4] * 6 + mRut[5] * 7 + mRut[6] * 2;
            }

            suma = suma % 11;
            suma = 11 - suma;

            if (suma == 11)
            {
                dv = "0";
            }
            if (suma == 10)
            {
                dv = "K";
            }
            if (suma >= 1 && suma <= 9)
            {
                dv = suma.ToString();
            }


            if (dv.Equals(digito.ToString()))
            {
                return true;
            }

            return false;
        }

        public static char digitoRut(int rut) 
        {
            string dv = "";

            int auxRut = rut;
            int[] mRut = new int[8];
            int suma = 0;

            for (int i = 0; i < rut.ToString().Length; i++)
            {
                mRut[i] = (auxRut % 10);
                auxRut = (auxRut / 10);
            }

            if (rut.ToString().Length == 8)
            {
                suma = mRut[0] * 2 + mRut[1] * 3 + mRut[2] * 4 + mRut[3] * 5 + mRut[4] * 6 + mRut[5] * 7 + mRut[6] * 2 + mRut[7] * 3;
            }
            else
            {
                suma = mRut[0] * 2 + mRut[1] * 3 + mRut[2] * 4 + mRut[3] * 5 + mRut[4] * 6 + mRut[5] * 7 + mRut[6] * 2;
            }

            suma = suma % 11;
            suma = 11 - suma;

            if (suma == 11)
            {
                dv = "0";
            }
            if (suma == 10)
            {
                dv = "K";
            }
            if (suma >= 1 && suma <= 9)
            {
                dv = suma.ToString();
            }

            
            return char.Parse(dv);
        }

        public static string encriptar(string clave) 
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(clave);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string desencriptar(string claveEn) 
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(claveEn);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        
        public static Boolean buscarContrasena(string user, string pass) 
        {
            foreach (Usuario me in usuarios )
            {
                if (me.User.Equals(user) && me.Contrasena.Equals(pass))
                {
                    return true;
                }
            }
            return false;

        }
    }


}

   
