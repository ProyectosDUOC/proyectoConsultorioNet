using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio
{
    public class EnfermeraLColeccion
    {
        public static List<EnfermeraListar> GenerarListado()
        {

            List<EnfermeraListar> enfermeras = new List<EnfermeraListar>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var enfer = ee.Enfermera;
            

            foreach (capaDatos.Enfermera enf in enfer.ToList())
            {
                EnfermeraListar enfermera = new EnfermeraListar();
                Usuario usuario = new Usuario();
                Nacionalidad nacionalidad = new Nacionalidad();
                Genero genero = new Genero();
                Comuna comuna = new Comuna();

                usuario.Id = (int)enf.id_usuario;
                usuario.Read();
                enfermera.Id = enf.id_enfermera;
                enfermera.Rut = usuario.Rut;
                enfermera.Dv = usuario.Dv;
                enfermera.Foto = usuario.Foto;
                enfermera.Pnombre = usuario.Pnombre;
                enfermera.Snombre = usuario.Snombre;
                enfermera.Appaterno = usuario.Appaterno;
                enfermera.Apmaterno = usuario.Apmaterno;
                enfermera.FechaNacimiento = usuario.FechaNacimiento;
                enfermera.Direccion = usuario.Direccion;
                enfermera.Fono1 = usuario.Fono1;
                enfermera.Fono2 = usuario.Fono2;
                enfermera.Activo = usuario.Activo;

                genero.Id = usuario.IdGenero;
                genero.Read();
                enfermera.Genero = genero.Nombre;

                nacionalidad.Id = usuario.IdNacionalidad;
                nacionalidad.Read();
                enfermera.Nacionalidad = nacionalidad.Nombre;

                comuna.Id = usuario.IdComuna;
                comuna.Read();
                enfermera.Comuna = comuna.Nombre;

                enfermeras.Add(enfermera);
            }
            return enfermeras;
        }

        public static EnfermeraListar BuscarCompleto(int id_u)
        {

            EnfermeraListar enfermera1 = new EnfermeraListar();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var enfer = ee.Enfermera;


            foreach (capaDatos.Enfermera enf in enfer.ToList())
            {

                if (enf.id_usuario == id_u)
                {
                    EnfermeraListar enfermera = new EnfermeraListar();
                    Usuario usuario = new Usuario();
                    Sector sector = new Sector();
                    Nacionalidad nacionalidad = new Nacionalidad();
                    Genero genero = new Genero();
                    Comuna comuna = new Comuna();
                    GrupoSanguineo gs = new GrupoSanguineo();
                    Rh_sanguineo rh = new Rh_sanguineo();

                    usuario.Id = (int)enf.id_usuario;
                    usuario.Read();
                    enfermera.Id = enf.id_enfermera;
                    enfermera.Rut = usuario.Rut;
                    enfermera.Dv = usuario.Dv;
                    enfermera.Foto = usuario.Foto;
                    enfermera.Pnombre = usuario.Pnombre;
                    enfermera.Snombre = usuario.Snombre;
                    enfermera.Appaterno = usuario.Appaterno;
                    enfermera.Apmaterno = usuario.Apmaterno;
                    enfermera.FechaNacimiento = usuario.FechaNacimiento;
                    enfermera.Direccion = usuario.Direccion;
                    enfermera.Fono1 = usuario.Fono1;
                    enfermera.Fono2 = usuario.Fono2;
                    enfermera.Activo = usuario.Activo;

                    genero.Id = usuario.IdGenero;
                    genero.Read();
                    enfermera.Genero = genero.Nombre;

                    nacionalidad.Id = usuario.IdNacionalidad;
                    nacionalidad.Read();
                    enfermera.Nacionalidad = nacionalidad.Nombre;

                    comuna.Id = usuario.IdComuna;
                    comuna.Read();
                    enfermera.Comuna = comuna.Nombre;

                    enfermera1 = enfermera;

                    break;
                }                
               
            }
            return enfermera1;
        }
    }
}
