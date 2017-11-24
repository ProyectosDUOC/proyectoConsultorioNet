using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;
using System.Data.Entity;

namespace capaNegocio.ClasesListar
{
    public class RecetaMedicametosColeecion
    {
        public static List<capaNegocio.ClasesListar.RecetaMedicametos> generalListado() {
            List<RecetaMedicametos> listado = new List<RecetaMedicametos>();

            ConsultoriosEntities modelo = new ConsultoriosEntities();
            var receta = modelo.Receta_Medica;
            foreach (capaDatos.Receta_Medica  xx in receta.ToList())
	        {
		        RecetaMedicametos r = new RecetaMedicametos();

                r.IdReceta = xx.id_Receta_Medica;
                r.Glosa = xx.glosa;
                r.Hora = (int)xx.hora;
                r.Fecha = (DateTime)xx.fecha;
                r.Cant = (int)xx.cantidad;
                r.Glosa = xx.glosa;
                capaNegocio.Medicamentos medicamento = new capaNegocio.Medicamentos();
                medicamento.Id = (int)xx.id_medicamentos;
                medicamento.Read();
                r.Nombre = medicamento.Nombre;
                r.Dia = (int)xx.dia;

                listado.Add(r);
	        }

            return listado;

        }

        public static List<capaNegocio.ClasesListar.RecetaMedicametos> generalListado(int ficha)
        {
            List<RecetaMedicametos> listado = new List<RecetaMedicametos>();

            ConsultoriosEntities modelo = new ConsultoriosEntities();
            var receta = modelo.Receta_Medica;
            foreach (capaDatos.Receta_Medica xx in receta.ToList())
            {
                if (xx.id_ficha_paciente == ficha )
                {
                    RecetaMedicametos r = new RecetaMedicametos();
                    r.IdReceta = xx.id_Receta_Medica;
                    r.Glosa = xx.glosa;
                    r.Hora = (int)xx.hora;
                    r.Fecha = (DateTime)xx.fecha;
                    r.Cant = (int)xx.cantidad;
                    r.Glosa = xx.glosa;
                    capaNegocio.Medicamentos medicamento = new capaNegocio.Medicamentos();
                    medicamento.Id = (int)xx.id_medicamentos;
                    medicamento.Read();
                    r.Nombre = medicamento.Nombre;
                    r.Dia = (int)xx.dia;
                    listado.Add(r);  
                }                             
            }

            return listado;

        }
    }
}
