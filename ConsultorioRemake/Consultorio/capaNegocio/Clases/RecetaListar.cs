using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio.Clases
{
    public class RecetaListar
    {
        public static List<RecetaMedica> generarReceta() {
            List<RecetaMedica> listar = new List<RecetaMedica>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var fichas = ee.Receta_Medica;


            foreach (capaDatos.Receta_Medica xx in fichas.ToList())
            {
                capaNegocio.Clases.RecetaMedica re = new RecetaMedica();

                re.IdFicha = (int)xx.id_ficha_paciente;
                re.Hora = (int)xx.hora;
                re.IdMedicamento = (int)xx.id_medicamentos;
                re.IdReceta = xx.id_Receta_Medica;
                re.Glosa = xx.glosa;
                re.Fecha = (DateTime)xx.fecha;
                re.Cant = (int)xx.cantidad;
                re.Dia = (int)xx.dia;
                listar.Add(re);
            }
            return listar;        
        
        }

        public static List<RecetaMedica> generarReceta(int idFicha)
        {
            List<RecetaMedica> listar = new List<RecetaMedica>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var fichas = ee.Receta_Medica;


            foreach (capaDatos.Receta_Medica xx in fichas.ToList())
            {
                if (idFicha == xx.id_ficha_paciente)
                {
                    capaNegocio.Clases.RecetaMedica re = new RecetaMedica();

                    re.IdFicha = (int)xx.id_ficha_paciente;
                    re.Hora = (int)xx.hora;
                    re.IdMedicamento = (int)xx.id_medicamentos;
                    re.IdReceta = xx.id_Receta_Medica;
                    re.Glosa = xx.glosa;
                    re.Fecha = (DateTime)xx.fecha;
                    re.Cant = (int)xx.cantidad;
                    re.Dia = (int)xx.dia;
                    listar.Add(re);
                }              
            }
            return listar;

        }
    }
}
