using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca.Control;

namespace Biblioteca.Controladores
{
    public class LicenciaMedicaColeccion
    {
          private static List<LicenciaMedica> licenciasM= new List<LicenciaMedica>();

        public LicenciaMedicaColeccion(){
            licenciasM = new List<LicenciaMedica>();
        }         


        public  Boolean agregar(LicenciaMedica licencia) 
        {
            if (buscar(licencia.IdLicencia) == null)
            {
                licenciasM.Add(licencia);
                return true;
            }           
            return false;
        }

        public static LicenciaMedica buscar(uint id)
        {
            LicenciaMedica lm = new LicenciaMedica();

            foreach (LicenciaMedica li in licenciasM )
	        {
		            if(li.IdLicencia == id)
                    {
                        lm = li;
                        return lm;  
                    }
	        }
            return null;
        }

        public List<LicenciaMedica> listar() 
        {
            return  licenciasM;
        }

        public Boolean modificar(LicenciaMedica licen) 
        {
            int x = 0;

            foreach (LicenciaMedica li in licenciasM)
            {
                if (li.IdLicencia == licen.IdLicencia)
                {
                   licenciasM.Insert(x, licen);
                    return true;
                }
                x++;
            }
            return false;
        }
        public Boolean eliminar(uint id) 
        {
            int x = 0;
            foreach (LicenciaMedica li in licenciasM)
            {
                if (li.IdLicencia == id )
                {
                    licenciasM.RemoveAt(x);
                    return true;
                }
                x++;
            }
            return false;
        }
    }
}
