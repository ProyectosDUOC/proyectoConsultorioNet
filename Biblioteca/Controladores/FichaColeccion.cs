using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Control;

namespace Biblioteca.Controladores
{
    public class FichaColeccion
    {
        private static List<FichaPaciente> fichas= new List<FichaPaciente>();

        public FichaColeccion(){
          fichas = new List<FichaPaciente>();
        }
        
        // se deberia tener uno por cada tipo de persona 
        // problema o error : dado en el caso que si un medico, enfermera o doctor es paciente
        // generare un error al ingresarlo porque ya existe el rut


        public  Boolean agregar(FichaPaciente ficha) 
        {
            if (buscar(ficha.idfichaMedica) == null)
            {
                fichas.Add(ficha);
                return true;
            }           
            return false;
        }

        public static FichaPaciente buscar(uint id)
        {
            FichaPaciente ficha = new FichaPaciente();

            foreach (FichaPaciente fi in fichas )
	        {
		            if(fi.idfichaMedica == id)
                    {
                        ficha = fi;
                        return ficha;                            
                    }
	        }
            return null;
        }

        public List<FichaPaciente> listar() 
        {
            return fichas;
        }

        public Boolean modificar(FichaPaciente fi) 
        {
            int x = 0;
            
            foreach (FichaPaciente ficha in fichas)
            {
                if (ficha.idfichaMedica == fi.idfichaMedica)
                {
                   fichas.Insert(x, fi);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(int id) 
        {
            int x = 0;
            foreach (FichaPaciente ficha in fichas)
            {
                if (ficha.idfichaMedica== id )
                {
                    fichas.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }

    }
}
