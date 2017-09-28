using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Controladores
{
    public class ControlAccesoColeccion
    {
         //CRUd
        private static List<ControlAcceso> controlesAccesos = new List<ControlAcceso>();

        public ControlAccesoColeccion() 
        {
         controlesAccesos = new List<ControlAcceso>();
        }
        

        public  Boolean agregar(ControlAcceso controlAcceso) 
        {
            if (buscar(controlAcceso.id) == null && controlAcceso != null)
            {
                controlesAccesos.Add(controlAcceso);
                return true;
            }           
            return false;
        }

        public static ControlAcceso buscar(int id)
        {
            foreach (ControlAcceso control in controlesAccesos)
            {
                if (control.id.Equals(id))
                {                   
                    return control;
                }
                
            }
            return null;
        }

        public List<ControlAcceso> listar() 
        {

            return controlesAccesos;
        }

        public Boolean modificar(ControlAcceso controls) 
        {
            int x = 0;
            foreach (ControlAcceso control in controlesAccesos)
            {
                if (control.id.Equals(controls.id))
                {
                   controlesAccesos.Insert(x, controls);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(int id)
        {
            int x = 0;
            foreach (ControlAcceso control in controlesAccesos)
            {
                if (control.id.Equals(id))
                {
                    controlesAccesos.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }
        
    }
}
