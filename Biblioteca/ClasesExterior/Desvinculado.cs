using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca.ClasesExterior
{
    public class Desvinculado
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private TipoDesvinculado tipoDesvinculado;

        public TipoDesvinculado TipoDesvinculado
        {
            get { return tipoDesvinculado; }
            set { tipoDesvinculado = value; }
        }
        private String glosa;

        public String Glosa
        {
            get { return glosa; }
            set { glosa = value; }
        }

        public Desvinculado() {
            Init();
        }

        private void Init() {
            id = 0;
            usuario = null;
            fecha = DateTime.Now;
            tipoDesvinculado = null;
            glosa = String.Empty;
        }
    }
}
