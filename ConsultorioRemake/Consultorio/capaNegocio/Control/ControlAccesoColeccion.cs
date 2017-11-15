using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using capaDatos;

namespace capaNegocio
{
    public class ControlAccesoColeccion
    {
        public static List<ControlAcceso> GenerarListado(List<capaDatos.Control_Acceso> controlAccesoDALC)
        {
            List<capaNegocio.ControlAcceso> controlAccesos = new List<ControlAcceso>();

            foreach (capaDatos.Control_Acceso control in controlAccesoDALC)
            {
                capaNegocio.ControlAcceso controlA= new ControlAcceso();

                controlA.Id = control.id_control_acceso;
                controlA.Username = control.usuario_login;
                controlA.Pass = control.contrasena;
                controlA.IdTipoUsuario = control.id_tipo_usuario;
                controlA.IdUsuario = control.id_tipo_usuario;
                controlA.Activo = (int)control.activo;

                controlAccesos.Add(controlA);
            }
            return controlAccesos;
        }

        //Listado de todos los elementos

        public List<ControlAcceso> ReadAll() {
            var controlAccesos = CommonBC.ModeloConsultorio.Control_Acceso;
            return GenerarListado(controlAccesos.ToList());            
        }

    }
}
