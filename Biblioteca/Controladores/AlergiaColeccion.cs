using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;
using Biblioteca.Control;

namespace Biblioteca.Controladores
{
    public class AlergiaColeccion
    {
          private static List<Alergia> alergias = new List<Alergia>();

        public AlergiaColeccion(){
            alergias = new List<Alergia>();
        }
        

        public  Boolean agregar(Alergia aler) 
        {
            if (buscar(aler.Id) == null && aler != null)
            {
                alergias.Add(aler);
                return true;
            }           
            return false;
        }

        public static Alergia buscar(int id)
        {
            foreach (Alergia al in alergias)
            {
                if (al.Id.Equals(id))
                {                   
                    return al;
                }
                
            }
            return null;
        }

        public List<Alergia> listar() 
        {

            return alergias;
        }

        public Boolean modificar(Alergia aler) 
        {
            int x = 0;
            foreach (Alergia al in alergias)
            {
                if (al.Id.Equals(aler.Id))
                {
                   alergias.Insert(x, aler);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(int id)
        {
            int x = 0;
            foreach (Alergia aler in alergias)
            {
                if (aler.Id.Equals(id))
                {
                    alergias.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }
        
    }
}
