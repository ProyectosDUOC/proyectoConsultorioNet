using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace capaNegocio
{
    public class TipoUsuarioColeccion
    {
        List<TipoUsuario> GenerarListado(List<capaDatos.Tipo_Usuario> usuariosDALC)
        {
            List<TipoUsuario> tipo_usuarios = new List<TipoUsuario>();

            foreach (capaDatos.Tipo_Usuario tipouserDALC in usuariosDALC)
            {
                TipoUsuario tipouser = new TipoUsuario();
                tipouser.Id = tipouserDALC.id_tipo_usuario;
                tipouser.Nombre = tipouserDALC.nom_tipo_usuario;

                tipo_usuarios.Add(tipouser);
            }
            return tipo_usuarios;
        }
    }
}
