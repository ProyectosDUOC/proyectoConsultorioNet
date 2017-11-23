using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio.ClasesListar
{
    public class FichaLColeccion
    {

        public static List<capaNegocio.ClasesListar.FichaLListar> generarListado() {
            List<FichaLListar> listar = new List<FichaLListar>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var fichas = ee.Ficha_Paciente;


            foreach (capaDatos.Ficha_Paciente xx in fichas.ToList())
            {
                FichaLListar ficha = new FichaLListar();

                ficha.IdFicha = xx.id_ficha_paciente;
                Paciente pac = new Paciente();
                pac.Id = (int)xx.id_paciente;
                pac.Read();
                Usuario usu = new  Usuario();
                usu.Id = pac.IdUsuario;
                usu.Read();

                ficha.Nombre = usu.Pnombre + " " + usu.Snombre + " " + usu.Appaterno + " " + usu.Apmaterno;
                ficha.Rut = usu.Rut + "-" + usu.Dv;
                ficha.Fecha = (DateTime)xx.fecha;
                Sector sector = new Sector();
                sector.Id = (int)pac.IdSector;
                sector.Read();
                ficha.Sector = sector.Nombre;

                listar.Add(ficha);
            }
            return listar;        
        }
    }
}
