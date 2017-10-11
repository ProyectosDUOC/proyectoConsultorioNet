using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDatos;
using System.Data.Entity;

namespace Biblioteca.Control
{
    public class Sector
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Sector() {
            Init();
        }

        public Sector(int id, string nombre) {
            Id = id;
            Nombre = nombre;
        }
        private void Init() {
            id = 0;
            nombre = String.Empty;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id Sector: {0} nombre: {1}", id, nombre);
            return sb.ToString();
        }

        public string AgregarSector() {
            try
            {
                ConsultoriosEntities con = new ConsultoriosEntities();

                CapaDatos.Sector sect = new CapaDatos.Sector();
                sect.id_sector = id;
                sect.nombre = nombre;

                con.AddToSector(sect);
                con.SaveChanges();
                return "Agregado";
            
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
    }
}
