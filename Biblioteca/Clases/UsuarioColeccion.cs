using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.Clases
{
    public class UsuarioColeccion
    {
       public List<Usuario> GenerarListado(List<Consultiorios.DALC.Usuario> UsuarioDALC)
        {
            List<Biblioteca.Usuario> usuarios= new List<Usuario>();

            foreach (Consultiorios.DALC.Usuario usua in UsuarioDALC)
            {
                Biblioteca.Usuario usuario= new Usuario();

                usuario.Id = usua.id_usuario;
                usuario.Rut = usua.rut_usuario;
                usuario.Dv = Char.Parse(usua.dv_usuario);
                usuario.Foto = usua.foto;
                usuario.Pnombre = usua.pnombre;
                usuario.Snombre = usua.snombre;
                usuario.Appaterno = usua.appaterno;
                usuario.Apmaterno = usua.apmaterno;
                usuario.FechaNacimiento = usua.fecha_nacimiento;
                usuario.Genero.Id = usua.id_genero;
                usuario.Nacionalidad.Id = usua.id_nacionalidad;
                usuario.Comuna.Id = usua.id_comuna;
                usuario.Direccion = usua.direccion;
                usuario.Fono1 = usua.fono1.ToString();
                usuario.Fono2 = usua.fono2.ToString();
                usuario.Activo = usua.activo;
                
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        //Listado de todos los elementos

        public List<Usuario> ReadAll()
        {
            var usuarios = CommonBC.ModeloConsultorio.Usuario;
            return GenerarListado(usuarios.ToList());
        }
    }
}
