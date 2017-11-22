using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class UsuarioColeccion
    {
       public static List<Usuario> GenerarListado(List<capaDatos.Usuario> UsuarioDALC)
        {
            List<capaNegocio.Usuario> usuarios= new List<Usuario>();

            foreach (capaDatos.Usuario usua in UsuarioDALC)
            {
                capaNegocio.Usuario usuario= new Usuario();

                usuario.Id = usua.id_usuario;
                usuario.Rut = (int)usua.rut_usuario;
                usuario.Dv = Char.Parse(usua.dv_usuario);
                usuario.Foto = usua.foto;
                usuario.Pnombre = usua.pnombre;
                usuario.Snombre = usua.snombre;
                usuario.Appaterno = usua.appaterno;
                usuario.Apmaterno = usua.apmaterno;
                usuario.FechaNacimiento = (DateTime)usua.fecha_nacimiento;
                usuario.IdGenero = (int)usua.id_genero;
                usuario.IdNacionalidad = (int)usua.id_nacionalidad;
                usuario.IdComuna = (int)usua.id_comuna;
                usuario.Direccion = usua.direccion;
                usuario.Fono1 = usua.fono1.ToString();
                usuario.Fono2 = usua.fono2.ToString();
                usuario.Activo = (int)usua.activo;
                
                usuarios.Add(usuario);
            }
            return usuarios;
        }

        //Listado de todos los elementos

        public static List<Usuario> ReadAll()
        {
            var usuarios = CommonBC.ModeloConsultorio.Usuario;
            return GenerarListado(usuarios.ToList());
        }

    }
}
