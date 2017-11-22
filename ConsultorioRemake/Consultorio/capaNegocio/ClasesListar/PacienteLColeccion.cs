using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using capaDatos;

namespace capaNegocio.ClasesListar
{
    public class PacienteLColeccion
    {
        public static List<PacienteListar> GenerarListado()
        {

            List<capaNegocio.ClasesListar.PacienteListar> pacientes = new List<PacienteListar>();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var paci = ee.Paciente;
            

            foreach (capaDatos.Paciente pac in paci.ToList())
            {
                capaNegocio.ClasesListar.PacienteListar paciente = new PacienteListar();
                capaNegocio.Usuario usuario = new Usuario();
                capaNegocio.Sector sector = new Sector();
                capaNegocio.Nacionalidad nacionalidad = new Nacionalidad();
                capaNegocio.Genero genero = new Genero();
                capaNegocio.Comuna comuna = new Comuna();
                capaNegocio.GrupoSanguineo gs = new GrupoSanguineo();
                capaNegocio.Rh_sanguineo rh = new Rh_sanguineo();

                usuario.Id = (int)pac.id_usuario;
                usuario.Read();
                paciente.Id = pac.id_paciente;
                paciente.Rut = usuario.Rut;
                paciente.Dv = usuario.Dv;
                paciente.Foto = usuario.Foto;
                paciente.Pnombre = usuario.Pnombre;
                paciente.Snombre = usuario.Snombre;
                paciente.Appaterno = usuario.Appaterno;
                paciente.Apmaterno = usuario.Apmaterno;
                paciente.FechaNacimiento = usuario.FechaNacimiento;
                paciente.Direccion = usuario.Direccion;
                paciente.Fono1 = usuario.Fono1;
                paciente.Fono2 = usuario.Fono2;
                paciente.Activo = usuario.Activo;

                genero.Id = usuario.IdGenero;
                genero.Read();
                paciente.Genero = genero.Nombre;

                nacionalidad.Id = usuario.IdNacionalidad;
                nacionalidad.Read();
                paciente.Nacionalidad = nacionalidad.Nombre;

                comuna.Id = usuario.IdComuna;
                comuna.Read();
                paciente.Comuna = comuna.Nombre;

                gs.Id = (int)pac.id_grupo_sanguineo;
                gs.Read();
                paciente.GrupoSanguineo = gs.Nombre;

                rh.Id = (int)pac.id_rh;
                rh.Read();
                paciente.Rh = rh.Nombre;

                sector.Id = (int)pac.id_sector;
                sector.Read();
                paciente.Sector = sector.Nombre;

                pacientes.Add(paciente);
            }
            return pacientes;
        }

        public static PacienteListar BuscarCompleto(int id_u)
        {

            PacienteListar paciente1 = new PacienteListar();

            ConsultoriosEntities ee = new ConsultoriosEntities();
            var paci = ee.Paciente;


            foreach (capaDatos.Paciente pac in paci.ToList())
            {

                if (pac.id_usuario == id_u)
                {
                    capaNegocio.ClasesListar.PacienteListar paciente = new PacienteListar();
                    capaNegocio.Usuario usuario = new Usuario();
                    capaNegocio.Sector sector = new Sector();
                    capaNegocio.Nacionalidad nacionalidad = new Nacionalidad();
                    capaNegocio.Genero genero = new Genero();
                    capaNegocio.Comuna comuna = new Comuna();
                    capaNegocio.GrupoSanguineo gs = new GrupoSanguineo();
                    capaNegocio.Rh_sanguineo rh = new Rh_sanguineo();

                    usuario.Id = (int)pac.id_usuario;
                    usuario.Read();
                    paciente.Id = pac.id_paciente;
                    paciente.Rut = usuario.Rut;
                    paciente.Dv = usuario.Dv;
                    paciente.Foto = usuario.Foto;
                    paciente.Pnombre = usuario.Pnombre;
                    paciente.Snombre = usuario.Snombre;
                    paciente.Appaterno = usuario.Appaterno;
                    paciente.Apmaterno = usuario.Apmaterno;
                    paciente.FechaNacimiento = usuario.FechaNacimiento;
                    paciente.Direccion = usuario.Direccion;
                    paciente.Fono1 = usuario.Fono1;
                    paciente.Fono2 = usuario.Fono2;
                    paciente.Activo = usuario.Activo;

                    genero.Id = usuario.IdGenero;
                    genero.Read();
                    paciente.Genero = genero.Nombre;

                    nacionalidad.Id = usuario.IdNacionalidad;
                    nacionalidad.Read();
                    paciente.Nacionalidad = nacionalidad.Nombre;

                    comuna.Id = usuario.IdComuna;
                    comuna.Read();
                    paciente.Comuna = comuna.Nombre;

                    gs.Id = (int)pac.id_grupo_sanguineo;
                    gs.Read();
                    paciente.GrupoSanguineo = gs.Nombre;

                    rh.Id = (int)pac.id_rh;
                    rh.Read();
                    paciente.Rh = rh.Nombre;

                    sector.Id = (int)pac.id_sector;
                    sector.Read();
                    paciente.Sector = sector.Nombre;

                    paciente1 = paciente;

                    break;
                }                
               
            }
            return paciente1;
        }
    }
}
