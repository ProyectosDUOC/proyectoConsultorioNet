using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Clases;

namespace Biblioteca.Controladores
{
    public class MedicamentoColeccion
    {
          private static List<Medicamento> medicamentos = new List<Medicamento>();

        public MedicamentoColeccion() 
        {
         medicamentos = new List<Medicamento>();
        }
        

        public  Boolean agregar(Medicamento medi) 
        {
            if (buscar(medi.id) == null && medi != null)
            {
                medicamentos.Add(medi);
                return true;
            }           
            return false;
        }

        public static Medicamento buscar(int id)
        {
            foreach (Medicamento me in medicamentos)
            {
                if (me.id.Equals(id))
                {                   
                    return me;
                }
                
            }
            return null;
        }

        public List<Medicamento> listar() 
        {

            return medicamentos;
        }

        public Boolean modificar(Medicamento medica) 
        {
            int x = 0;
            foreach (Medicamento control in medicamentos)
            {
                if (medica.id.Equals(medica.id))
                {
                    medicamentos.Insert(x, medica);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(int id)
        {
            int x = 0;
            foreach (Medicamento medi in medicamentos)
            {
                if (medi.id.Equals(id))
                {
                    medicamentos.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }
        
    }
}
